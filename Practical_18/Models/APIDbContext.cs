using Microsoft.EntityFrameworkCore;

namespace Practical_18.Models
{
    public class APIDbContext : DbContext   
    {
        public APIDbContext(DbContextOptions option):base(option)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
