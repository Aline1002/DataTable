using DataTable.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DataTable.Context;


namespace DataTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context.AppContext _context;
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger, Context.AppContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Original()
        {
            return View();
        }

        public IActionResult Tematica()
        {
            var empresas = _context.Empresas.OrderBy(x => x.RazaoSocial).ToList();
            return View(empresas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
