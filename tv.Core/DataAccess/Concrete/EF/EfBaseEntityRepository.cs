using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using tv.Core.DataAccess.Abstract;
using tv.Core.Entity.Abstract;

namespace tv.Core.DataAccess.Concrete.EF
{
    public class EfBaseEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Remove(entity);
                ctx.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext ctx = new TContext())
            {
                return ctx.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext ctx = new TContext())
            {
                return filter==null ? ctx.Set<TEntity>().ToList() : ctx.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Update(entity);
                ctx.SaveChanges();
            }
        }
    }
}
