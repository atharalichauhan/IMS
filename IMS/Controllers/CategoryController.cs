using AutoMapper;
using IMS.Core.Interfaces;
using IMS.Web.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IMS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork _uow;
        public CategoryController(ICategoryService categoryService, IUnitOfWork uow)
        {
            _categoryService = categoryService;
            _uow = uow;
        }

        // GET: Category
        public ViewResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            var categoryVm = Mapper.Map<List<CategoryViewModel>>(categories);
            return View(categoryVm);
        }

        public ViewResult Create()
        {
            return View();
        }

        public ViewResult Nav()
        {
            return View("base-navs");
        }

        public ViewResult Form()
        {
            return View("base-forms");
        }
        public ViewResult BreadCrumb()
        {
            return View("base-breadcrumb");
        }


    }
}