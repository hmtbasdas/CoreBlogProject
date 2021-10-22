using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentDal());
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult PartialCommentList(int id)
        {
            return PartialView(cm.GetList(id).ToList());
        }
    }
}
