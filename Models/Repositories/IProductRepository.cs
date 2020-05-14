using System.Linq;

namespace POS.Models {
    public interface IProductRepository {

        IQueryable<Product> Products { get; }
        Product GetById (int productId);
        void CreateProduct (Product product);
        void UpdateProduct (Product product);
        void DeleteProduct (int productId);

    }

}