using IMS.Core.Entities;
using System.Collections.Generic;

namespace IMS.Core.Interfaces
{
    public interface ICategoryService
    {
        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="category">Category</param>
        void DeleteCategory(Category category);

        /// <summary>
        /// Gets category
        /// </summary>
        /// <param name="Id">Category identifier</param>
        /// <returns>Category</returns>
        Category GetCategoryById(int Id);

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>Categories</returns>
        List<Category> GetAllCategories();

        /// <summary>
        /// Inserts a category
        /// </summary>
        /// <param name="category">Category</param>
        Category InsertCategory(Category category);

        /// <summary>
        /// Updates the category
        /// </summary>
        /// <param name="category">Category</param>
        void UpdateCategory(Category category);
    }
}
