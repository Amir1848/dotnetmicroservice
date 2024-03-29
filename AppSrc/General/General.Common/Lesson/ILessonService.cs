﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Common
{
    public interface ILessonService : IServiceBase<Lesson, Lesson>
    {
        Dictionary<long, string>  FetchLessonsWithTitles(HashSet<long> ids);
    }
}
