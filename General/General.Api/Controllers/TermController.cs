using FUM.BaseApi;
using General.Common;

namespace General.Api.Controllers
{
    public class TermController : FumControllerBase<Term, TermViewModel, ITermService>
    {
        public TermController(ITermService service) : base(service) { }
    }
}
