using Microsoft.AspNetCore.Mvc;
namespace dojoSurvey
{
    public class HomeController : Controller // Home is the name of the directory where all of these actions/views should reference
    {
        [HttpGet] //This renders the Form Submission Page
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Results(string name, string dojo, string language, string comment)
        {
            ViewBag.name = name;
            ViewBag.dojo = dojo;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View();
        }
    }
}