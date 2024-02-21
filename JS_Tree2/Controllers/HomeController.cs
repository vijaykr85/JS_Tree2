using JS_Tree2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JS_Tree2.Controllers
{
    public class HomeController : Controller
    {
        private readonly TreeContext _context;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(TreeContext context)
        {
            _context = context;
        }

        public IActionResult GetData()
        {
            var data = _context.trees.ToList();
            return Json(data);
        }



        public IActionResult AddData(TreeViewNode ob)
        {
            if (ModelState.IsValid)
            {
                _context.trees.Add(ob); // Assuming ob is an instance of TreeViewNode
                _context.SaveChanges();
            }
            return Json(ob);
        }

        [HttpPost]
        public IActionResult DeleteData(TreeViewNode obj)
        {
            if (ModelState.IsValid)
            {
                var data = _context.trees.Find(obj.id);
                if (data != null)
                {
                    _context.trees.Remove(data);
                    _context.SaveChanges();
                }
            }
            var records = _context.trees.ToList();
            return Json(records);
        }

        [HttpPost]
        public IActionResult UpdateData(TreeViewNode obj)
        {
            if (ModelState.IsValid)
            {
                _context.trees.Update(obj);
                _context.SaveChanges();
            }
            var records = _context.trees.ToList();
            return Json(records);
        }





        public IActionResult Index()
        {
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
