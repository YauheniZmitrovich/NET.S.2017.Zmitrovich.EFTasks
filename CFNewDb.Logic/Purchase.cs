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
    /// Purchase consist of different orders.
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// Id of purchase.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Orders with products.
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

        /// <summary>
        /// Create instance of <see cref="Purchase"/>
        /// </summary>
        public Purchase() { }
    }
}
