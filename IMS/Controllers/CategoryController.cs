using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.Web.ViewModels;

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

        //// GET: Category/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Category category = db.Categories.Find(id);
        //    if (category == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(category);
        //}

        // GET: Category/Create
        public ViewResult Create()
        {
            CategoryViewModel category = new CategoryViewModel();
            category.IsActive = true;
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,IsActive")] CategoryViewModel categoryVm)
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

        // GET: Category/Edit/5
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

            var categoryVm = Mapper.Map<Category, CategoryViewModel>(category);

            return View(categoryVm);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,IsActive")] CategoryViewModel categoryVm)
        {
            if (ModelState.IsValid)
            {
                var category = Mapper.Map<CategoryViewModel, Category>(categoryVm);
                _categoryService.UpdateCategory(category);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(categoryVm);
        }

        // GET: Category/Delete/5
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

        // POST: Category/Delete/5
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
