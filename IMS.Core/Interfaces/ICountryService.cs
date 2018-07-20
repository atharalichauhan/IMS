using IMS.Core.Entities;
using System.Collections.Generic;

namespace IMS.Core.Interfaces
{
    public interface ICountryService 
    {
        /// <summary>
        /// Delete a country
        /// </summary>
        /// <param name="country">Country</param>
        void DeleteCountry(Country country);

        /// <summary>
        /// Gets country
        /// </summary>
        /// <param name="Id">Country identifier</param>
        /// <returns>Country</returns>
        Country GetCountryById(int Id);

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>Countries</returns>
        List<Country> GetAllCountries();

        /// <summary>
        /// Inserts a country
        /// </summary>
        /// <param name="country">Country</param>
        Country InsertCountry(Country country);

        /// <summary>
        /// Updates the country
        /// </summary>
        /// <param name="country">Country</param>
        void UpdateCountry(Country country);
    }
}
