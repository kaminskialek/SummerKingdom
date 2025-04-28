using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all users (optional or pending implementation)
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            // View details of a specific user
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Show form to create a new user
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost()
        {
            // Handle creation of a new user
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            // Show form to edit a user
            return View();
        }

        [HttpPost("{id}/edit")]
        public IActionResult EditPost([FromRoute] int id)
        {
            // Handle editing of a user
            return RedirectToAction("Details", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting a user
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of a user
            return RedirectToAction("Index");
        }
    }

}
