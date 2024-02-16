using Calculations.Business.Helpers;
using Calculations.Common;
using Calculation.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business.Calculation
{
    public class CalculationService : ICalculationService
    {
        private StudentHelper _studentHelper;
        private IFeeService _feeService;
        public CalculationService(StudentHelper studentHelper, IFeeService feeService)
        {
            _studentHelper = studentHelper;
            _feeService = feeService;
        }

        public List<StudentSalaryInfo> CalculateSalaries(long termId)
        {
            var tas = _studentHelper.GetAllTeachingAssistants(new GetAllTeachingAssistantsReq
            {
                TermId = termId
            });

            var lessonIds = tas.TeachingAssistants.Select(p => p.LessonRef).ToHashSet();
            var lessonIdFeeDict = _feeService.GetLessonFeeDictionary(lessonIds);


            var studentIdNameMap = new Dictionary<long, string>();
            var StudentIdLessonsMap = new Dictionary<long, List<long>>();
            foreach (var ta in tas.TeachingAssistants)
            {
                if (StudentIdLessonsMap.ContainsKey(ta.Id))
                {
                    StudentIdLessonsMap[ta.Id].Add(ta.LessonRef);
                }
                else
                {
                    studentIdNameMap[ta.Id] = ta.StudentName + " " + ta.StudentLastName;
                    StudentIdLessonsMap[ta.Id] = new List<long>() { ta.LessonRef };
                }
            }

            var result = new List<StudentSalaryInfo>();
            foreach (var item in StudentIdLessonsMap)
            {
                var st = new StudentSalaryInfo()
                {
                    Amount = 0,
                    StudentId = item.Key,
                    StudentName = studentIdNameMap[item.Key]
                };

                var allLessonIds = item.Value;
                foreach (var lessonItem in allLessonIds)
                {
                    if (!lessonIdFeeDict.ContainsKey(lessonItem))
                    {
                        throw new Exception("selected lesson has not fee");
                    }
                    var lessonFee = lessonIdFeeDict[lessonItem];
                    st.Amount += lessonFee;
                }

                result.Add(st);
            }

            return result;
        }

        public List<StudentViewModel> GetTeachingAssistantStudents(long termId)
        {
            var tas = _studentHelper.GetAllTeachingAssistants(new GetAllTeachingAssistantsReq
            {
                TermId = termId
            });

            var result = tas.TeachingAssistants.Select(p => new StudentViewModel()
            {
                FullName = p.StudentCode,
                StudentCode = p.StudentCode,
                Id = p.Id
            }).ToList();

            return result;
        }
    }
}
