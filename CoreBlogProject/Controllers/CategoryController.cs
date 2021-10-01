using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public IActionResult Index()
        {
            return View(cm.GetList().ToList());
        }
    }
}
