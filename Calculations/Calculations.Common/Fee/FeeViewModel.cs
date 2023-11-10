using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Common
{
    public class FeeViewModel : IViewModel
    {
        public long ID { get; set; }
        public decimal Amount { get; set; }
        public long LessonRef { get; set; }
        public string LessonTitle { get; set; }
    }
}
