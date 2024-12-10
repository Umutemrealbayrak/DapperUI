using Microsoft.AspNetCore.Mvc;

namespace DapperUI.ViewComponents.HomePage
{
	public class _DefaultServiceComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
