using Microsoft.AspNetCore.Mvc;

namespace PortfolioI.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public IActionResult Contacts()
        {
            return View("Contact");
        }
    }
}

