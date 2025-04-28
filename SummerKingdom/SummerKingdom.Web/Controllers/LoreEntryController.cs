using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("loreentries")]
    public class LoreEntryController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all lore entries
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            // View details of a specific lore entry
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Show form to create a new lore entry
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost()
        {
            // Handle creation of a new lore entry
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            // Show form to edit a lore entry
            return View();
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditPost([FromRoute] int id)
        {
            // Handle editing of a lore entry
            return RedirectToAction("Details", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting a lore entry
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of a lore entry
            return RedirectToAction("Index");
        }
    }

}
