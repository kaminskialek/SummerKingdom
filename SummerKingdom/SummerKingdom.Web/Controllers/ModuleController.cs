using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("modules")]
    public class ModuleController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all modules
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            // View details of a specific module
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Show form to create a new module
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost()
        {
            // Handle creation of a new module
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            // Show form to edit a module
            return View();
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditPost([FromRoute] int id)
        {
            // Handle editing of a module
            return RedirectToAction("Details", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting a module
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of a module
            return RedirectToAction("Index");
        }
    }

}
