﻿using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.ViewModels;

namespace IMS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(ICategoryService categoryService, IUnitOfWork unitOfWork)
        {
            _categoryService = categoryService;
            _unitOfWork = unitOfWork;
        }

        public ViewResult Index()
        {
            return View(GetAllCategories());
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns>List of categories</returns>
        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            var categories = _categoryService.GetAllCategories();
            var categoriesVm = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return categoriesVm;
        }


        public ViewResult Create()
        {
            CategoryViewModel category = new CategoryViewModel();
            category.IsActive = true;
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel categoryVm)
        {
            if (ModelState.IsValid)
            {
                Category category = Mapper.Map<CategoryViewModel, Category>(categoryVm);
                _categoryService.InsertCategory(category);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(categoryVm);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _categoryService.GetCategoryById(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }

            CategoryViewModel categoryVm = Mapper.Map<Category, CategoryViewModel>(category);

            return View(categoryVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryViewModel categoryVm)
        {
            if (ModelState.IsValid)
            {
                Category category = Mapper.Map<CategoryViewModel, Category>(categoryVm);
                _categoryService.UpdateCategory(category);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(categoryVm);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _categoryService.GetCategoryById(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }

            var categoryVm = Mapper.Map<Category, CategoryViewModel>(category);
            return View(categoryVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = _categoryService.GetCategoryById(id);
            _categoryService.DeleteCategory(category);
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
