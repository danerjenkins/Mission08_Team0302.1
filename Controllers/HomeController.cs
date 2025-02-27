using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0302._1.Models;

namespace Mission08_Team0302._1.Controllers
{
    public class HomeController : Controller
    {
        private iTasksRepository _repo;

        public HomeController(iTasksRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _repo.Categories.ToList();
            return View();
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
