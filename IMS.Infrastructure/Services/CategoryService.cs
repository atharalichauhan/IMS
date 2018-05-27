using System;
using System.Collections.Generic;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.Infrastructure.Data;

namespace IMS.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="categoryRepository">CategoryRepository</param>
        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="Category">Category</param>
        public void DeleteCategory(Category Category)
        {
            if (Category == null)
                throw new ArgumentNullException("Category");

            _categoryRepository.Delete(Category);

        }

        /// <summary>
        /// Gets Category
        /// </summary>
        /// <param name="Id">Category identifier</param>
        /// <returns>Category</returns>
        public Category GetCategoryById(int Id)
        {
            return _categoryRepository.GetById(Id);
        }

        /// <summary>
        /// Insert a Category
        /// </summary>
        /// <param name="Category">Category</param>
        public Category InsertCategory(Category Category)
        {
            if (Category == null)
                throw new ArgumentNullException("Category");

           return _categoryRepository.Add(Category);
        }

        /// <summary>
        /// Updates the Category
        /// </summary>
        /// <param name="Category">Category</param>
        public void UpdateCategory(Category Category)
        {
            if (Category == null)
                throw new ArgumentNullException("Category");

            _categoryRepository.Update(Category);
        }

        public List<Category> GetAllCategories()
        {
            //   var categories = _categoryRepository.List();
            var categories = new List<Category>()
            {
                new Category { Id = 1,Name = "Drinks", Description = "Beverages",IsActive = true },
                new Category { Id = 2, Name = "Chocolates", Description = "Candies", IsActive = true}
            };
            return categories;
        }
    }
}
