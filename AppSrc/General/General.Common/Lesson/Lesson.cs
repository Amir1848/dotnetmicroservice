using Common;

namespace General.Common
{
    public class Lesson : Entity, IViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        internal virtual List<Course> Courses { get; set; }
    }
}
