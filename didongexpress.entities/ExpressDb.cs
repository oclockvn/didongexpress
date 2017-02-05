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

        // we need to create more entities and more dbset (mean table)
        // and here we go

        public DbSet<Category> Categories { get; set; }

        // just enough for now, we will add more table later
    }
}
