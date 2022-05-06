using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDnetWorld.Controllers
{
    [Route("/waddupworld")]
    public class HelloController1 : Controller
    {
        // GET: HelloController1
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<h1>Waddup World</h1>"+
                "<form method='post' action='/waddupworld'>" +
                "<input type='text' name='name'> " +
                "<input type='submit' value='enter a name'> </form>";
            Console.WriteLine("HelloController endpoint hit");
            return Content(html, "text/html");
        }

        // endpoint url  /helloController1/results
        //public IActionResult Results()
        //{
        //    string  results = "<p style='color: red'>string of results<p>";
        //    return Content(results, "text/html");

        //}

        //[HttpGet("/country/{country?}")]
        //public IActionResult TestRoute(string country = "germany")
        //{
        //    string selectedCountry = $"<h1>{country}</h1>";
        //    return Content(selectedCountry, "text/html");
        //}

        [HttpGet("/waddupworld/{name?}")]
        [HttpPost]
        // GET: HelloController1/Details/5
        public ActionResult Details(string name = "world")
        {
            string html = $"<h1 style='color: red'>{name}</h1>";
            return Content(html, "text/html");
        }

   

        //    // GET: HelloController1/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: HelloController1/Create
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create(IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: HelloController1/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: HelloController1/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: HelloController1/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: HelloController1/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
    }
}
