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
    /// Categories of products.
    /// </summary>
    public enum ProductCategory : int
    {
        edible, inedible
    }

    /// <summary>
    /// Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id of product.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Name of product.
        /// </summary>
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }

        /// <summary>
        /// Description of product.
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        /// <summary>
        /// Price of product.
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Category of product.
        /// </summary>
        [Required]
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Image of product.
        /// </summary>
        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        /// <summary>
        /// Create an object of <see cref="Product"/>.
        /// </summary>
        public Product() { }
    }
}
