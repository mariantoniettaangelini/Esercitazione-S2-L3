using Esercitazione.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercitazione.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult VendiBiglietto(Ticket ticket) 
        {
            if (ModelState.IsValid) 
            {
                Sala.AddTicket(ticket);
                return RedirectToAction("Index"); 
            }
            return View(ticket); 
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
