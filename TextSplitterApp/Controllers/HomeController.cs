using Microsoft.AspNetCore.Mvc;
using TextSplitterApp.Models;

namespace TextSplitterApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            TextViewModel textViewModel = new TextViewModel();
            
            return View(textViewModel);
        }

        [HttpPost]
        public IActionResult Index(TextViewModel textViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(textViewModel);
            }

            textViewModel.SplitText = string.Join("\n", textViewModel.Text.Split(" "));
           
            return View(textViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
