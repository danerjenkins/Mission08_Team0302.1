using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0302._1.Models;
using Task = Mission08_Team0302._1.Models.Task;

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

        public IActionResult AddTask()
        {
            
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.name)
                .ToList();
            
            return View(new Task());
        }

        [HttpPost]
        public IActionResult AddTask(Task task)
        {

            if (ModelState.IsValid)
            {
                _repo.AddTask(task);

                return RedirectToAction("Quadrants");
            }
            else
            {
                ViewBag.Categories = _repo.Categories
                    .OrderBy(x => x.name)
                    .ToList();

                return View(task);
            }
        }

        public IActionResult Quadrants()
        {
            var tasks = _repo.Tasks.ToList();
            
            return View(tasks);
        }
        
        public IActionResult Edit(int taskId)
        {
            var item = _repo.Tasks
                .Single(x => x.TaskId == taskId);
            
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.name)
                .ToList();
            
            return View("AddTask", item);
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateTask(task);
                
                return RedirectToAction("Quadrants");
            }
            else
            {
                return View("AddTask", task);
            }
        }

        public IActionResult Delete(int taskId)
        {
            var taskToDelete = _repo.Tasks.Single(x => x.TaskId == taskId);
            
            return View(taskToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            _repo.DeleteTask(task);
            
            return RedirectToAction("Quadrants");
        }

    }
}
