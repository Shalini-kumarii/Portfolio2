using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers     //be sure to use your own project's namespace!
{
    public class PortfolioController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        // [HttpGet]       //type of request
        // [Route("")]     //associated route string (exclude the leading /)
        [HttpGet("")]      // Both upper lines can be written in one line
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public IActionResult Project(string project)
        {

            return View("Projects");
        }

        [HttpGet("contact")]
        public IActionResult Contact(string project)
        {

            return View("Contact");
            
        }
    
[HttpGet("send")]
        public IActionResult Send()
        {
            // Do something with form input
            return RedirectToAction("Index");
        }





    }
}

