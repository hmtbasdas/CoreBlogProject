using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        public IActionResult Index()
        {
            return View(bm.GetBlogListWithCategory());
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.BlogID = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
    }
}
