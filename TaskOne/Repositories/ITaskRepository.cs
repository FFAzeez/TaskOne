using System.Collections.Generic;
using System.Threading.Tasks;
using TaskOne.Model;

namespace TaskOne.Repositories
{
    public interface ITaskRepository
    {
        Task<bool> Create(Tasks task);
        Task<Tasks> GetByIdAsync(int Id);
        Task<List<Tasks>> GetAllAsync();
    }
}