using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("adventures")]
    public class AdventureController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all adventures
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            // View details of a specific adventure
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Show form to create a new adventure
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost()
        {
            // Handle creation of a new adventure
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            // Show form to edit an adventure
            return View();
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditPost([FromRoute] int id)
        {
            // Handle editing an adventure
            return RedirectToAction("Details", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting an adventure
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of an adventure
            return RedirectToAction("Index");
        }
    }

}
