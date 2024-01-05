using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace General.Common
{
    public class StudentCourse : Entity, IViewModel
    {
        public long StudentRef { get; set; }
        public long CourseRef { get; set; }
        public ClassRole Role { get; set; }

        [JsonIgnore]
        internal virtual Student Student { get; set; }
        [JsonIgnore]
        internal virtual Course Course { get; set; }  
    }

    public enum ClassRole
    {
        Student = 1,
        TA = 2
    }
}
