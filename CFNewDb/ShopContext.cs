using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CFNewDb.Logic
{
    /// <summary>
    /// Context for working with database.
    /// </summary>
    public class ShopContext : DbContext
    {
        /// <summary>
        /// Create an instance of <see cref="ShopContext"/>.
        /// </summary>
        public ShopContext() : base() { }

        /// <summary>
        /// Products.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Orders of products.
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Purchases with orders.
        /// </summary>
        public DbSet<Purchase> Purchases { get; set; }
    }
}
