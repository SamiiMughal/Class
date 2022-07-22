using Category.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace Category.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }
        public DbSet<CategoryModel> Categories { get; set; }

    }
}
