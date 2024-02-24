
namespace CodeMePro.Repositories
{
    public interface IGenericRepository
    {
        IQueryable<T> GetAll<T>() where T : class;
        Task<T> GetByIdAsync<T>(int id) where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(int id) where T : class;
    }

}


