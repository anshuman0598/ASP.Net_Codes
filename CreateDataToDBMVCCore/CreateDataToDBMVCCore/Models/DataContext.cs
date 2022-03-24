using Microsoft.EntityFrameworkCore;

namespace CreateDataToDBMVCCore.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

    }
}


