using IfaceMainApi.Data;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace IfaceMainApi.src.Repositories
{
    public class RepositoryBase<T>(AppDbContext dbContext) : IRepositoryBase<T> where T : EntityBase
    {
        private readonly AppDbContext _dbContext = dbContext;
        protected readonly DbSet<T> _dbSet = dbContext.Set<T>();

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<T> SaveAsync(T entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            await _dbSet.AddAsync(entity);
            return entity;
        }
    }
}
