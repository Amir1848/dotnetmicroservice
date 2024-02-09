using FUM.BaseBusiness.Services;
using General.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business
{
    public class TermService : ServiceBase<Term, TermViewModel, GeneralDbContext>, ITermService
    {
        public TermService(GeneralDbContext ctx) :base(ctx)
        {

        }
        public override TermViewModel FetchByID(long id)
        {
            return (
                from t in FetchAll()
                select new TermViewModel
                {
                    ID = t.ID,
                    End = t.End,
                    Start = t.Start,
                    Title = t.Title,
                }).Single();
        }
    }
}
