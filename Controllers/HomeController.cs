using Lab4.Data;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        private readonly SportsDbContext _context;

        public HomeController(SportsDbContext context)
        {
            _context = context;
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
