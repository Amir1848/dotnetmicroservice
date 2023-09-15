using FUM.BaseBusiness.Services;
using General.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business
{
    public class CourseService : ServiceBase<Course, StudentViewModel, GeneralDbContext>, IStudentService
    {
    }
}
