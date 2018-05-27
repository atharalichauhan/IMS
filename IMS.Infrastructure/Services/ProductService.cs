using System;
using System.Collections.Generic;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.Infrastructure.Data;

namespace IMS.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly Repository<Product> _productRepository;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="productRepository">ProductRepository</param>
        public ProductService(Repository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="product">Product</param>
        public void DeleteProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");
            
                _productRepository.Delete(product);
            
        }

        public List<Product> GetAllProducts()
        {
            var products = _productRepository.List();
            return products;
        }


        /// <summary>
        /// Gets product
        /// </summary>
        /// <param name="Id">Product identifier</param>
        /// <returns>Product</returns>
        public Product GetProductById(int Id)
        {
           return _productRepository.GetById(Id);
        }

        /// <summary>
        /// Insert a product
        /// </summary>
        /// <param name="product">Product</param>
        public Product InsertProduct(Product product)
        {
            if(product == null)
                 throw new ArgumentNullException("product");
            
               return _productRepository.Add(product);           
        }

        /// <summary>
        /// Updates the product
        /// </summary>
        /// <param name="product">Product</param>
        public void UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            _productRepository.Update(product);
        }
    }
}
