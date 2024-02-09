using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace General.Common
{
    [Serializable]
    public  class Student : Entity
    {
        public string StudentCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonIgnore]
        internal virtual ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
