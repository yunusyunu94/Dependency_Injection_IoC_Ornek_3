using Dependency_Injection_IoC_Ornek_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Injection_IoC_Ornek_3.Controllers
{

    // LÝNK ; https://www.youtube.com/watch?v=Lx1KDdbycJY   



    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbConfigurations _dbConfigurations;
        private readonly IServiceProvider _serviceProvider;

        public HomeController(ILogger<HomeController> logger, DbConfigurations dbConfigurations,
            IServiceProvider serviceProvider)
        {
            _logger = logger;
            _dbConfigurations = dbConfigurations;
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            //var dbCOnfiguration = new DbConfigurations();
            var sp = _serviceProvider.GetService<DbConfigurations>();
            ViewBag.OperationId = sp.OperationId;


            return View(_dbConfigurations);
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
