using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Common
{
    public class Fee : Entity
    {
        public long LessonRef { get; set; }
        public decimal Amount { get; set; }
        
    }
}
