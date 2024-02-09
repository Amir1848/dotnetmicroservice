using FUM.BaseBusiness.Services;
using General.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business
{
    public class CourseService : ServiceBase<Course, CourseViewModel, GeneralDbContext>, ICourseService
    {

        public CourseService(GeneralDbContext ctx) :base(ctx)
        {

        }

        public override CourseViewModel FetchByID(long id)
        {
            return FetchAll().Where(p => p.ID == id).Select(propa => new CourseViewModel
            {
                ID = propa.ID,
                Code = propa.Code,  
                Description = propa.Description,
                Title = propa.Title 
            }).SingleOrDefault();
        }
    }
}
