using FUM.BaseBusiness.Services;
using General.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business
{
    public class StudentCourseService : ServiceBase<StudentCourse, StudentCourse, GeneralDbContext>, IStudentCourseService
    {
        public StudentCourseService(GeneralDbContext ctx): base(ctx)
        {
            
        }
        public override StudentCourse FetchByID(long id)
        {
            return FetchEntityByID(id);
        }
    }
}
