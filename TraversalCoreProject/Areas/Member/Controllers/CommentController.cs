using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]

    //Doğrulama ve diğer kuralları geçmek için kullanıyoruz.
    [AllowAnonymous]

    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
