﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Common
{
    public class CourseViewModel : IViewModel
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
