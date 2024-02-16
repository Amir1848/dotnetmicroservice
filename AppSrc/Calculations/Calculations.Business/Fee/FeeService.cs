using Calculations.Business.DbContext;
using Calculations.Business.Helpers;
using Calculations.Common;
using Calculations.Grpc.Protos;
using FUM.BaseBusiness.Services;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business
{
    public class FeeService : ServiceBase<Fee, FeeViewModel, CalculationsDbContext>, IFeeService
    {
        private readonly LessonHelper _lessonHelper;
        public FeeService(CalculationsDbContext ctx, LessonHelper lessonHelper) :base(ctx) 
        {
            _lessonHelper = lessonHelper;
        }

        public override FeeViewModel FetchByID(long id)
        {
            var result = FetchAll().Where(p => p.ID == id).Select(p => new FeeViewModel
            {
                ID = p.ID,
                Amount = p.Amount,
                LessonRef = p.LessonRef,
            }).Single();

            var titles = _lessonHelper.GetLessonTitles(new LessonTitleReq()
            {
                LessonIds = { id },
            });

            result.LessonTitle = titles.Lessons[0].Title;
            return result;
        }

        public Dictionary<long, decimal> GetLessonFeeDictionary(HashSet<long> lessonIds)
        {
            var result = FetchAll().Where(p => lessonIds.Contains(p.LessonRef)).
                ToDictionary(p => p.LessonRef, p => p.Amount);
            return result;
        }
    }
}
