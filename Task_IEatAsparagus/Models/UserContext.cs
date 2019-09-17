using System.Data.Entity;

namespace Task_IEatAsparagus.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}