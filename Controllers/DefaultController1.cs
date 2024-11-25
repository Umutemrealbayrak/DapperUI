using Microsoft.AspNetCore.Mvc;

namespace DapperUI.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
