using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class CommentController : Controller
    {
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult PartialCommentList()
        {
            return PartialView();
        }
    }
}
