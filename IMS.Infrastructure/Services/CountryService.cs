using IMS.Core.Entities;
using IMS.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace IMS.Infrastructure.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> _country;

        public CountryService(IRepository<Country> country)
        {
            _country = country;
        }

        public void DeleteCountry(Country country)
        {
            if (country == null)
                throw new ArgumentNullException("Country");
            _country.Delete(country);
        }

        public List<Country> GetAllCountries()
        {
            return _country.List();
        }

        public Country GetCountryById(int Id)
        {
            return _country.GetById(Id);
        }

        public Country InsertCountry(Country country)
        {
            if (country == null)
                throw new ArgumentNullException("Country");
            return _country.Add(country);
        }

        public void UpdateCountry(Country country)
        {
            if (country == null)
                throw new ArgumentNullException("Country");
            _country.Update(country);
        }
    }
}
