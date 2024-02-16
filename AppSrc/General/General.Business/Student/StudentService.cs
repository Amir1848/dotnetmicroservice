using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Common;
using FUM.BaseBusiness.Services;
using General.Common;
using Microsoft.EntityFrameworkCore;

namespace General.Business
{
    public class StudentService : ServiceBase<Student, StudentViewModel, GeneralDbContext>, IStudentService
    {
        private ITermService _termService;
        private ICourseService _courseService;

        public StudentService(GeneralDbContext ctx,
                ITermService termService,
                ICourseService courseService
            ): base(ctx)
        {
            _termService = termService;
            _courseService = courseService;
        }

        public void AddStudentToCourse(List<StudentCourse> studentCourses)
        {
            foreach (var item in studentCourses)
            {
                this._dbContext.StudentCourse.Add(item);   
            }
            this._dbContext.SaveChanges();
        }

        public IQueryable<StudentCourse> FetchAllStudentCourses()
        {
            return _dbContext.Set<StudentCourse>().AsNoTracking();
        }

        public override StudentViewModel FetchByID(long id)
        {
            return FetchAll().Where(p => p.ID == id).Select(propa => new StudentViewModel
            {
                ID = propa.ID,
                FirstName = propa.FirstName,
                LastName = propa.LastName,
                StudentCode = propa.StudentCode,
            }).SingleOrDefault();
        }

        public List<TeachingAssistantStudentViewModel> GetTeachingAssistants(long termId)
        {
            var students = (from term in _termService.FetchAll()
                            join course in _courseService.FetchAll() on term.ID equals course.TermRef
                            join stCourse in FetchAllStudentCourses() on course.ID equals stCourse.CourseRef
                            join st in FetchAll() on stCourse.StudentRef equals st.ID
                            where term.ID == termId && stCourse.Role == ClassRole.TA
                            select new TeachingAssistantStudentViewModel()
                            {
                                CourseName = course.Title,
                                FirstName = st.FirstName,
                                LastName = st.LastName,
                                StudentCode = st.StudentCode,
                                Id = st.ID,
                                TermTitle = term.Title,
                                LessonRef = course.LessonRef
                            }).ToList();

            return students;
        }
    }
}
