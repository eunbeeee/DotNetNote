using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();  // /Demo/Index라고 입력하면 보여주는 코드
        }
    }
}
