using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Common
{
    public class StudentViewModel
    {
        public long Id { get; set; }
        public string StudentCode { get; set; }
        public string FullName { get; set; }
    }

    public class StudentSalaryInfo
    {
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public decimal Amount { get; set; }

    }

    //public class LessonInfoViewModel
    //{
    //    public long LessonId { get; set; }
    //    public string LessonTitle { get; set; }
    //}

}
