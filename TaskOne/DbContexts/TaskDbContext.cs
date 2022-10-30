using Microsoft.EntityFrameworkCore;
using TaskOne.Model;

namespace TaskOne.DbContexts
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> option):base(option)
        {
        }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
