using L_LA_01_GAMF.Data;
using L_LA_01_GAMF.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L_LA_01_GAMF.Controllers
{
    public class HomeController : Controller
    {
        private readonly GAMFDbContext _context;
        public HomeController(GAMFDbContext dbContext) {
            _context = dbContext;
        }

        public IActionResult Index() { 
            var students = _context.Students.ToList();
            return View();
        
        }

    }
}
