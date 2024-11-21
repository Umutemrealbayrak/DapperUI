using Microsoft.AspNetCore.Mvc;

namespace DapperUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
