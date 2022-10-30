using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskOne.DbContexts;
using TaskOne.Model;

namespace TaskOne.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        readonly TaskDbContext _context;
        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Tasks task)
        {
            await _context.AddAsync(task);
            return await SaveAsync();
        }

        public async Task<Tasks> GetByIdAsync(int Id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<List<Tasks>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
