﻿using Common;
using FUM.BaseBusiness.Services;
using General.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business
{
    public class LessonService : ServiceBase<Lesson, Lesson, GeneralDbContext>, ILessonService
    {
        public LessonService(GeneralDbContext ctx) : base(ctx)
        {

        }
        public override Lesson FetchByID(long id)
        {
            return FetchEntityByID(id);
        }

        public Dictionary<long, string> FetchLessonsWithTitles(HashSet<long> ids)
        {
            return FetchAll().Where(p => ids.Contains(p.ID)).ToDictionary(p => p.ID, p => p.Title);
        }
    }
}
