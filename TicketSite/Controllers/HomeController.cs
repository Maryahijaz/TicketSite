using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using TicketSite.Data;
using TicketSite.Models;

namespace TicketSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IConfiguration _configuration, ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer(_configuration.GetConnectionString("TicketSite"));
            _context = new ApplicationDbContext(optionBuilder.Options);
        }

        public IActionResult Index()
        {
            var localizedTitle = _localizer["Uşak bileti ara"];
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


        [HttpGet]
        public IActionResult UcusSorgusu(string Departure, string Destination, DateTime? departuredate)
        {

            var sonuc1 = _context.Flights
                .Where(x => x.FlightDeparture.Contains(Departure) &&
                x.FlightDestination.Contains(Destination) &&
                   (departuredate == null || DateTime.Compare(x.FlightDepartureDate.Date, departuredate.Value.Date) == 0))
               .ToList();

            return View("Sonuc", sonuc1);
        }
    }
}