using Common;
using FUM.BaseBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUM.BaseApi.Helper
{
    public class BaseServiceHelper<TEntity, TViewModel, TService> 
        where TEntity : Entity, new()
        where TViewModel: IViewModel
        where TService : IServiceBase<TEntity, TViewModel>
    {
        protected TService service;
        public BaseServiceHelper(TService service) {
            this.service = service; 
        }
    }
}
