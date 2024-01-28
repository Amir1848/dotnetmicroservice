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

        [HttpPost]
        public IActionResult AddStudentToCourse([FromBody] A a)
        {
            this._service.AddStudentToCourse(a.StudentCourses);
            return Ok();
        }
    }

    public class A
    {
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
