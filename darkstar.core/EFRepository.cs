using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace darkstar.core
{
    public class EFRepository<TEntity,TId> :  IEFRepository<TEntity,TId> where TEntity : class
    {

        DbContext _ctx;
        DbSet<TEntity> _dbSet;

        public EFRepository(DbContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<TEntity>();
        }
        public void Add(TEntity p1)
        {
            try
            {
                _dbSet.Add(p1);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(TEntity p1)
        {
            _dbSet.Attach(p1);
            _ctx.Entry(p1).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Delete(TId Id)
        {
            var entity = _dbSet.Find(Id);
            Delete(entity);
            _ctx.SaveChanges();
        }

        public void Delete(TEntity p1) 
        {
            if (_ctx.Entry(p1).State == EntityState.Detached) _dbSet.Attach(p1);
            _dbSet.Remove(p1);
        }
    }
}
