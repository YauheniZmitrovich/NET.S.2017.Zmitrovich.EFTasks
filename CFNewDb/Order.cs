using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFNewDb.Logic
{
    /// <summary>
    /// Order with quantity of products.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id of order.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Quantity of orders.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Create an object of <see cref="Order"/>
        /// </summary>
        public Order() { }

        /// <summary>
        /// An ordered product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Purchase with this order.
        /// </summary>
        public virtual Purchase Purchase { get; set; }
    }
}
