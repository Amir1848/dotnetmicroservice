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
        public CalculationService(StudentHelper studentHelper)
        {
            _studentHelper = studentHelper;
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
