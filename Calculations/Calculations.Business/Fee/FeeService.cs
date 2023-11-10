using Calculations.Business.DbContext;
using Calculations.Common;
using FUM.BaseBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Business
{
    public class FeeService : ServiceBase<Fee, FeeViewModel, CalculationsDbContext>, IFeeService
    {
        public FeeService(CalculationsDbContext ctx) :base(ctx) { }

        public override FeeViewModel FetchByID(long id)
        {
            var result = FetchAll().Where(p => p.ID == id).Select(p => new FeeViewModel
            {
                ID = p.ID,
                Amount = p.Amount,
                LessonRef = p.LessonRef,
            }).Single();

            return result;
        }
    }
}
