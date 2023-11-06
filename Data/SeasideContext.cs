using Microsoft.EntityFrameworkCore;
using seaside.api.Entities;

namespace seaside.api.Data
{
    public class SeasideContext : DbContext
    {
        public SeasideContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>().HasData(
                    new Todo()
                    {
                        Id = 10000,
                        Name = "Buy Milk",
                        Complete = false,
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    },
                    new Todo()
                    {
                        Id = 10001,
                        Name = "Rake Leaves",
                        Complete = false,
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    },
                    new Todo()
                    {
                        Id = 10002,
                        Name = "Pick Up Dry Cleaning",
                        Complete = false,
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    },
                    new Todo()
                    {
                        Id = 10003,
                        Name = "Clean Grill",
                        Complete = false,
                        CreatedAt = DateTime.Now,
                        ModifiedAt = DateTime.Now
                    }
            );
        }
    }
}