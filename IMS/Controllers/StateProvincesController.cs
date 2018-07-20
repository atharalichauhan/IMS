using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.ViewModels;

namespace IMS.Controllers
{
    public class StateProvincesController : Controller
    {
        private readonly IStateProvinceService _stateProvinceService;
        private readonly ICountryService _countryService;
        private readonly IUnitOfWork _unitOfWork;

        public StateProvincesController(IStateProvinceService stateProvinceService, ICountryService countryService, IUnitOfWork unitOfWork)
        {
            _stateProvinceService = stateProvinceService;
            _countryService = countryService;
            _unitOfWork = unitOfWork;
        }


        public ViewResult Index()
        {
            return View(GetAllStateProvinces());
        }

        private IEnumerable<StateProvinceViewModel> GetAllStateProvinces()
        {
            var stateProvinces = _stateProvinceService.GetAllStateProvinces();
            var stateProvincesVm = Mapper.Map<IEnumerable<StateProvince>, IEnumerable<StateProvinceViewModel>>(stateProvinces);
            return stateProvincesVm;
        }

        public ViewResult Create()
        {
            var stateProvinceVm = new StateProvinceViewModel
            {
                IsActive = true,
                Countries = new SelectList(_countryService.GetAllCountries(), "Id", "Name")
            };
            return View(stateProvinceVm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StateProvinceViewModel stateProvinceVm)
        {
            if (ModelState.IsValid)
            {
                var stateProvince = Mapper.Map<StateProvinceViewModel, StateProvince>(stateProvinceVm);
                _stateProvinceService.InsertStateProvinces(stateProvince);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            stateProvinceVm.Countries = new SelectList(_countryService.GetAllCountries(), "Id", "Name", stateProvinceVm.CountryId);
            return View(stateProvinceVm);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var stateProvince = _stateProvinceService.GetStateProvinceById(id.Value);
            if (stateProvince == null)
            {
                return HttpNotFound();
            }
            var stateProvinceVm = Mapper.Map<StateProvince, StateProvinceViewModel>(stateProvince);
            stateProvinceVm.Countries = new SelectList(_countryService.GetAllCountries(), "Id", "Name", stateProvinceVm.CountryId);
            return View(stateProvinceVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StateProvinceViewModel stateProvinceVm)
        {
            if (ModelState.IsValid)
            {
                var stateProvince = Mapper.Map<StateProvinceViewModel, StateProvince>(stateProvinceVm);
                _stateProvinceService.UpdateStateProvince(stateProvince);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            stateProvinceVm.Countries = new SelectList(_countryService.GetAllCountries(), "Id", "Name", stateProvinceVm.CountryId);
            return View(stateProvinceVm);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var stateProvince = _stateProvinceService.GetStateProvinceById(id.Value);
            if (stateProvince == null)
            {
                return HttpNotFound();
            }

            var stateProvinceVm = Mapper.Map<StateProvince, StateProvinceViewModel>(stateProvince);
            return View(stateProvinceVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var stateProvince = _stateProvinceService.GetStateProvinceById(id);
            _stateProvinceService.DeleteStateProvince(stateProvince);
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
