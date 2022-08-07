using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Data
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
