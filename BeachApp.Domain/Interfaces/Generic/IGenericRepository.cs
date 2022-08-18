namespace BeachApp.Domain.Interfaces.Generic
{
    public interface IGenericRepository<T>  where T : class
    {
        Task CreateEntityAsync(T entity);
        Task<bool> UpdateEntityAsync(T entity);
        Task<bool> DeleteEntityAsync(T entity);
        Task<IEnumerable<T>> GetAllEntityAsync(int? id);
        Task<T> GetByIdAsync(int id);
    }
}