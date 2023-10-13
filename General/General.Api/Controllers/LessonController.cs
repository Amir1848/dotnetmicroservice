using FUM.BaseApi;
using General.Common;
using Microsoft.AspNetCore.Mvc;

namespace General.Api.Controllers
{
    public class LessonController : FumControllerBase<Lesson, Lesson, ILessonService>
    {
        public LessonController(ILessonService service) : base(service)
        {

        }



    }
}
