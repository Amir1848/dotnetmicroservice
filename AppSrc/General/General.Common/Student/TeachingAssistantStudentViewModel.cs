using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Common
{
    public class TeachingAssistantStudentViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentCode { get; set; }
        public string CourseName { get; set; }
        public string TermTitle { get; set; }
        public long LessonRef { get; set; }
    }
}
