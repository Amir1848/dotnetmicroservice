using Common;
using FUM.BaseApi;
using General.Business;
using General.Common;

namespace General.Api.Controllers
{
    public class StudentController : FumControllerBase<Student, StudentViewModel, IStudentService>
    {

        public StudentController() { }
    }
}
