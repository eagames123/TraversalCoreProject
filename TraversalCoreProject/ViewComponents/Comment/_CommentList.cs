using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
