using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Common
{
    [Serializable]
    public  class Student : Entity
    {
        public string StudentCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
