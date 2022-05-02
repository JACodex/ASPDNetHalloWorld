using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDnetWorld.Controllers
{
    public class HelloController1 : Controller
    {
        // GET: HelloController1
        [HttpGet]
        [Route("/waddupworld/")]
        public IActionResult Index()
        {
            string html = "<h1>Waddup World</h1>";
            Console.WriteLine("HelloController endpoint hit");
            return Content(html, "text/html");
        }

        // endpoint url  /helloController1/results
        public IActionResult Results()
        {
            string  results = "<p style='color: red'>string of results<p>";
            return Content(results, "text/html");

        }

    //    // GET: HelloController1/Details/5
    //    public ActionResult Details(int id)
    //    {
    //        return View();
    //    }

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
