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
            return View();
        }

    }
}