using Common;
using FUM.BaseApi;
using General.Business;
using General.Common;
using Microsoft.AspNetCore.Mvc;

namespace General.Api.Controllers
{
    
    public class StudentController : FumControllerBase<Student, StudentViewModel, IStudentService>
    {

        public StudentController(IStudentService service): base(service) { }
    }
}
