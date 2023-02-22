using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewData["mystring1"] = "I am ViewData !";
            ViewBag.mystring2 = "I am ViewBag !";
            //ViewData[]
            return View("index1");
        }
        public string Step1(string name)
        {
            return $"I am {name}";
        }
    }
}
