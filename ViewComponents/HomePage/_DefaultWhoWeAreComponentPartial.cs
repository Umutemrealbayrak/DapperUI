using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapper.Dtos.ProductDtos;


namespace DapperUI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
