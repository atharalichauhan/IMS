using AutoMapper;
using IMS.Core.Entities;
using IMS.Core.Interfaces;
using IMS.Web.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace IMS.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IProductService productService, ICategoryService categoryService, IUnitOfWork unitOfWork)
        {
            _productService = productService;
            _categoryService = categoryService;
            _unitOfWork = unitOfWork;
        }


        public ActionResult Index()
        {
            return View(GetAllProducts());
        }


        private IEnumerable<ProductViewModel> GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            var productsVm = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return productsVm;
        }


        public ActionResult Create()
        {
            var productVm = new ProductViewModel();
            productVm.IsActive = true;
            var categories = _categoryService.GetAllCategories();
            productVm.Categories = new SelectList(categories, "Id", "Name");
            return View(productVm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productVm)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productVm);
                _productService.InsertProduct(product);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(productVm);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = _productService.GetProductById(id.Value);

            if (product == null)
            {
                return HttpNotFound();
            }

            var productVm = Mapper.Map<Product, ProductViewModel>(product);

            productVm.Categories = new SelectList(_categoryService.GetAllCategories(), "Id", "Name", productVm.CategoryId);
            return View(productVm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productVm)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productVm);
                _productService.UpdateProduct(product);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(productVm);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _productService.GetProductById(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }

            var productVm = Mapper.Map<Product, ProductViewModel>(product);
            return View(productVm);
        }


        [ActionName("Delete"), HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productService.GetProductById(id);
            _productService.DeleteProduct(product);
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
