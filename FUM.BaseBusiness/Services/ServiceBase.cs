using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FUM.BaseBusiness.Services
{
    public abstract class ServiceBase<TEntity, TViewModel, TDBContext> : IServiceBase<TEntity, TViewModel>
        where TEntity : Entity
        where TViewModel : IViewModel
        where TDBContext : DbContext
    {
        protected TDBContext _dbContext;
        public ServiceBase(TDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual Expression<Func<TEntity, bool>> GetIDCondition(long? id)
        {
            if (id.HasValue)
            {
                return p => p.ID == id;
            }
            else
            {
                return p => true;
            }
        }

        public virtual IQueryable<TEntity> FetchAll(bool trackChanges = false) => !trackChanges ? _dbContext.Set<TEntity>().AsNoTracking() : _dbContext.Set<TEntity>();
        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression, bool trackChanges = false) => !trackChanges ? _dbContext.Set<TEntity>().Where(expression).AsNoTracking() : _dbContext.Set<TEntity>().Where(expression);
        public virtual long Create(TEntity entity, bool saveChanges = true)
        {
            var res = _dbContext.Set<TEntity>().Add(entity);
            if (saveChanges)
            {
                _dbContext.SaveChanges();
            }
            return res.Entity.ID;
        }
        public virtual void Update(TEntity entity, bool saveChanges = true)
        {
            _dbContext.Set<TEntity>().Update(entity);
            if (saveChanges)
            {
                _dbContext.SaveChanges();
            }
        }
        public virtual void Delete(TEntity entity, bool saveChanges = true)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            if (saveChanges)
            {
                _dbContext.SaveChanges();
            }
        }

        public virtual TViewModel FetchViewModelByID(long id)
        {
            return FetchByID(id);
        }

        public abstract TViewModel FetchByID(long id);

        public void Delete(long id)
        {
            var entity = Where(p => p.ID == id).Single();
            Delete(entity);
        }
    }
}
