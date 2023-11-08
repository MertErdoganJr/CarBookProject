using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailLeaveACommentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View();
        }
    }
}
