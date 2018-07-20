using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.ViewModels;

namespace IMS.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly IUnitOfWork _unitOfWork;

        public CountryController(ICountryService countryService, IUnitOfWork unitOfWork)
        {
            _countryService = countryService;
            _unitOfWork = unitOfWork;
        }

        public ViewResult Index()
        {
            return View(GetAllCountries());
        }

        /// <summary>
        /// Get All Countries
        /// </summary>
        /// <returns>List of countries</returns>
        public IEnumerable<CountryViewModel> GetAllCountries()
        {
            var countries = _countryService.GetAllCountries();
            var countriesVm = Mapper.Map<IEnumerable<Country>, IEnumerable<CountryViewModel>>(countries);
            return countriesVm;
        }


        public ViewResult Create()
        {
            CountryViewModel countryVm = new CountryViewModel
            {
                IsActive = true
            };
            return View(countryVm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CountryViewModel countryVm)
        {
            if (ModelState.IsValid)
            {
                Country country = Mapper.Map<CountryViewModel, Country>(countryVm);
                _countryService.InsertCountry(country);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(countryVm);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = _countryService.GetCountryById(id.Value);
            if (country == null)
            {
                return HttpNotFound();
            }

            CountryViewModel countryVm = Mapper.Map<Country, CountryViewModel>(country);

            return View(countryVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CountryViewModel countryVm)
        {
            if (ModelState.IsValid)
            {
                Country country = Mapper.Map<CountryViewModel, Country>(countryVm);
                _countryService.UpdateCountry(country);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(countryVm);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = _countryService.GetCountryById(id.Value);
            if (country == null)
            {
                return HttpNotFound();
            }

            var countryVm = Mapper.Map<Country, CountryViewModel>(country);
            return View(countryVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = _countryService.GetCountryById(id);
            _countryService.DeleteCountry(country);
            _unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
