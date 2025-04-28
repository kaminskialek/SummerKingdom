using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("dungeons")]
    public class DungeonController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all dungeons
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            // View details of a specific dungeon
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Show form to create a new dungeon (select related adventure inside form or pass adventure ID)
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost()
        {
            // Handle creation of a new dungeon and map it to an adventure
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            // Show form to edit a dungeon
            return View();
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditPost([FromRoute] int id)
        {
            // Handle editing of a dungeon
            return RedirectToAction("Details", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting a dungeon
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of a dungeon
            return RedirectToAction("Index");
        }
    }

}
