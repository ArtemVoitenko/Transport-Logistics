using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Transport_Logistics.Context;

namespace Transport_Logistics.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class 
    {
        protected readonly TransportDbContext dbContext;
        private DbSet<TEntity> _dbSet;

        public Repository(TransportDbContext dbContext)
        {
            this.dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            _dbSet.Add(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}