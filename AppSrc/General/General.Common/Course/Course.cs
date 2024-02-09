using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace General.Common
{
    public class Course : Entity
    {
        public string Title { get; set; }   
        public string Description { get; set; }
        public string Code { get; set; }
        public long LessonRef { get; set; }
        public long TermRef { get; set; }

        [JsonIgnore]
        internal virtual Lesson Lesson { get; set; }
        [JsonIgnore]
        internal virtual Term Term { get; set; }
        [JsonIgnore]
        internal virtual List<StudentCourse> StudentCourses { get; set; }
    }
}
