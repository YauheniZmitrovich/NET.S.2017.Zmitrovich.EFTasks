using CFNewDb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFNewDb.Services
{
    /// <summary>
    /// Service of products.
    /// </summary>
    public sealed class ProductService : IContextService<Product>
    {
        #region Private fields

        private readonly ShopContext _context;

        #endregion

        #region Constructors

        /// <summary>
        /// Create instance of <see cref="ProductService"/>.
        /// </summary>
        /// <param name="context"> Database context inheritanced DbContext.
        public ProductService(ShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(Product));
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds product to the database.
        /// </summary>
        /// <param name="pr"> The product to add. </param>
        public void Add(Product pr)
        {
            if (pr == null || pr.Name == null || pr.Description == null)
                throw new ArgumentException("Incorrect product.");

            using (var db = new ShopContext())
            {
                db.Products.Add(pr);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Remove product from database.
        /// </summary>
        public void Remove(Product pr)
        {
            if (pr == null)
                throw new ArgumentNullException(nameof(pr));

            _context.Products.Remove(_context.Products.First(ent => ent.Id == pr.Id));
        }

        /// <summary>
        /// Updates product in database.
        /// </summary>
        public void Update(Product toChange, Product toSet)
        {
            Product pr = _context.Products.Where(s => s.Equals(toChange)).FirstOrDefault<Product>();

            if (pr == null)
                throw new ArgumentException("Incorrect input data.");

            pr = toSet;

            _context.Entry(pr).State = System.Data.Entity.EntityState.Modified;

            _context.SaveChanges();
        }

        /// <summary>
        /// Save list from storage.
        /// </summary>
        public void SaveToStorage(IStorage<Product> storage)
        {
            if (storage == null)
                throw new ArgumentNullException(nameof(storage));

            storage.Save(_context.Products);
        }

        /// <summary>
        /// Load list of products from storage.
        /// </summary>
        public void LoadFromStorage(IStorage<Product> storage)
        {
            if (storage == null)
                throw new ArgumentNullException(nameof(storage));

            //TODO:

            _context.SaveChanges();
        }


    }
    #endregion
}

