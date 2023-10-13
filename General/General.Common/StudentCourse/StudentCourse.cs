using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Common
{
    public class StudentCourse : Entity, IViewModel
    {
        public long Id { get; set; }
        public long StudentRef { get; set; }
        public long CourseRef { get; set; }
        public ClassRole Role { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }  
    }

    public enum ClassRole
    {
        Student = 1,
        TA = 2
    }
}
