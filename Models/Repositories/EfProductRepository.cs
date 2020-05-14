using System.Linq;

namespace POS.Models {
    public class EfProductRepository : IProductRepository {
        private ApplicationDbContext _context;

        public EfProductRepository (ApplicationDbContext context) {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;

        public void CreateProduct (Product product) {
            _context.Products.Add (product); // isaretleme
            _context.SaveChanges (); // gerceklesme yeri
        }
       

        public void DeleteProduct (int productId) {
            var product = GetById (productId);
            if (product != null) {
                _context.Products.Remove (product);
                _context.SaveChanges ();
            }

        }

        public Product GetById (int productId) {
            return _context.Products.FirstOrDefault (i => i.ProductId == productId);
        }

        public void UpdateProduct (Product product) {
            _context.Products.Update (product);
            _context.SaveChanges ();

        }

        // USER FUNCTIONS

    }
}