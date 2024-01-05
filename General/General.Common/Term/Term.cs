using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace General.Common
{
    public class Term: Entity
    {
        public string Title { get; set; }    
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [JsonIgnore]
        internal virtual List<Course> Courses { get; set; }   

    }
}
