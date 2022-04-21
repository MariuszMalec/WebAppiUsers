using WebAppiUsers.Models;

namespace WebAppiUsers.Services
{
    public interface IRepositoryService<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task Insert(T person);

        T Get(int id);

        void Update(T person);

        void Delete(int id);
    }
}
