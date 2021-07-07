using Microsoft.AspNetCore.Mvc;

namespace Fignum.WebApplication.Features.Shared.Components.MainMenu
{
	public class MainMenu : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var viewModel = new MainMenuViewModel();
			return View("MainMenu", viewModel);
		}
    }
}
