using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("factions")]
    public class FactionController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all factions
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            // View details of a specific faction
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Show form to create a new faction
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost()
        {
            // Handle creation of a new faction
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            // Show form to edit a faction
            return View();
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditPost([FromRoute] int id)
        {
            // Handle editing of a faction
            return RedirectToAction("Details", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting a faction
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of a faction
            return RedirectToAction("Index");
        }
    }

}
