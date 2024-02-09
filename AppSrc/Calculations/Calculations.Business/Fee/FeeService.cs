using Calculations.Business.DbContext;
using Calculations.Common;
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
        public FeeService(CalculationsDbContext ctx) :base(ctx) { }

        public override FeeViewModel FetchByID(long id)
        {
            //var channel = GrpcChannel.ForAddress("http://localhost:5003");
            //var client = new LessonHelper.LessonHelperClient(channel);

            //var lessontitle = client.GetLessonTitles(new GetLessonTitlesReq()
            //{
            //    Ids = { id },

            //});

            //var result = FetchAll().Where(p => p.ID == id).Select(p => new FeeViewModel
            //{
            //    ID = p.ID,
            //    Amount = p.Amount,
            //    LessonRef = p.LessonRef,
            //}).Single();

            //result.LessonTitle = lessontitle.Titles[0].Title;

            //return result;

            throw new NotImplementedException();
        }
    }
}
