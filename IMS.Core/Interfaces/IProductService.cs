using IMS.Core.Entities;
using System.Collections.Generic;

namespace IMS.Core.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Delete a product
        /// </summary>
        /// <param name="product">Product</param>
        void DeleteProduct(Product product);

        /// <summary>
        /// Gets product
        /// </summary>
        /// <param name="Id">Product identifier</param>
        /// <returns>Product</returns>
        Product GetProductById(int Id);

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>Products</returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Inserts a product
        /// </summary>
        /// <param name="product">Product</param>
        Product InsertProduct(Product product);

        /// <summary>
        /// Updates the product
        /// </summary>
        /// <param name="product">Product</param>
        void UpdateProduct(Product product);

    }
}
