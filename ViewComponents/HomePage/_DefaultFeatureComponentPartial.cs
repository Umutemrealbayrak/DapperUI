using Microsoft.AspNetCore.Mvc;

namespace DapperUI.ViewComponents.HomePage
{
	public class _DefaultFeatureComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
