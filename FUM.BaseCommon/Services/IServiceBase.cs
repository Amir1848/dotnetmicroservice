using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IServiceBase<TEntity, TViewModel>
    where TEntity : Entity
    where TViewModel : IViewModel
    {
        IQueryable<TEntity> FetchAll(bool trackChanges = false);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression,
        bool trackChanges);
        long Create(TEntity entity, bool saveChanges = true);
        void Update(TEntity entity, bool saveChanges = true);
        void Delete(TEntity entity, bool saveChanges = true);
        void Delete(long id);
        TViewModel FetchViewModelByID(long id);
        IQueryable<TViewModel> GetEntityViewModelQuery();
    }
}
