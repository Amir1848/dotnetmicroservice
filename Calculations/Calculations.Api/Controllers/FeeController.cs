using Calculations.Common;
using FUM.BaseApi;
using Microsoft.AspNetCore.Mvc;

namespace Calculations.Api.Controllers
{
    public class FeeController : FumControllerBase<Fee, FeeViewModel, IFeeService>
    {
        public FeeController(IFeeService service) : base(service)
        {

        }
    }
}
