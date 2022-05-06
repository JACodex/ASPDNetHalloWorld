using Microsoft.AspNetCore.Mvc;

namespace HelloASPDnetWorld.Controllers
{
    [Route("/country")]
    public class CountryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("<h1>enter a country</h1>", "text/html");
        }

        [HttpGet("/country/selectedCountry/{country?}")]
        public IActionResult SelectedCountry(string country = "United States")
        {
            string selectedCountry = $"<h1 style='color: blue'>{country}</h1>";
            return Content(selectedCountry, "text/html");
        }
    }
}
