using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarViewComponents
{
    public class _CarDetailTabPaneComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
