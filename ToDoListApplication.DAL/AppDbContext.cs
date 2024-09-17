using Microsoft.EntityFrameworkCore;
using ToDoListApplication.Domain.Entity;

namespace ToDoListApplication.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}