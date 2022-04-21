using WebAppiUsers.Models;

namespace WebAppiUsers.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAll();
        IQueryable<T> GetAllQueryable();
        T Get(int id);
        Task Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
