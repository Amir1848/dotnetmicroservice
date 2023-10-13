using FUM.BaseApi;
using General.Common;
using Microsoft.AspNetCore.Mvc;

namespace General.Api.Controllers
{
    public class CourseController : FumControllerBase<Course, CourseViewModel, ICourseService>
    {
        public CourseController(ICourseService service) :base(service)
        {

        }
    }
}
