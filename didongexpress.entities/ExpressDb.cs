
using System.Data.Entity;

namespace didongexpress.entities
{
    /// <summary>
    /// database context, must be inherited from System.Data.Entity.DbContext
    /// </summary>
    public class ExpressDb : DbContext
    {
        /// <summary>
        /// you can specify connection string in the constructor
        /// small trick for you
        /// </summary>
        public ExpressDb()
#if DEBUG
            :base("DevConnection") // used in development environment
#elif !DEBUG
            :base("ProductConnection") // used in production
#endif
        {

        }

        /// <summary>
        /// this is table of product
        /// follow by naming convention EntityName + 's' (but this is optional)
        /// You can name it whatever you want
        /// For example
        /// </summary>
        public DbSet<Product> Products { get; set; }        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }

        // customer + posts + bla bla...
    }
}
