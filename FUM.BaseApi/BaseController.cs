using Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUM.BaseApi
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class FumControllerBase<TEntity, TViewModel, TService> : ControllerBase
        where TEntity : Entity
        where TViewModel : IViewModel
        where TService : IServiceBase<TEntity, TViewModel>
    {
        protected readonly TService _service;
        public FumControllerBase(TService service) : base()
        {
            _service = service;
        }

        [HttpPost]
        public virtual IActionResult Save([FromBody] TEntity entity)
        {
            var res = _service.Create(entity);
            return Ok(res);
        }

        [HttpGet]
        public virtual TViewModel Get(long id)
        {
            return _service.FetchViewModelByID(id);
        }

        [HttpPut]
        public virtual IActionResult Update([FromBody] TEntity entity)
        {
            _service.Update(entity);
            return Ok();
        }

        [HttpDelete]
        public virtual IActionResult Delete( long id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
