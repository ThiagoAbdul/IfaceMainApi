using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase 
    {
        Task<T?> GetByIdAsync(Guid id);

        Task<T> SaveAsync(T entity);
    }
}
