using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("characters")]
    public class CharacterController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // List all characters (PCs and NPCs)
            return View();
        }

        [HttpGet("players")]
        public IActionResult PlayerCharacters()
        {
            // List all player characters (PCs)
            return View();
        }

        [HttpGet("npcs")]
        public IActionResult NonPlayerCharacters()
        {
            // List all non-player characters (NPCs)
            return View();
        }

        [HttpGet("players/{id}")]
        public IActionResult PlayerCharacterDetails([FromRoute] int id)
        {
            // View details of a specific player character
            return View();
        }

        [HttpGet("npcs/{id}")]
        public IActionResult NonPlayerCharacterDetails([FromRoute] int id)
        {
            // View details of a specific non-player character
            return View();
        }

        [HttpGet("players/create")]
        public IActionResult CreatePlayerCharacter()
        {
            // Show form to create a new player character
            return View();
        }

        [HttpPost("players/create")]
        public IActionResult CreatePlayerCharacterPost()
        {
            // Handle creation of a new player character
            return RedirectToAction("PlayerCharacters");
        }

        [HttpGet("npcs/create")]
        public IActionResult CreateNonPlayerCharacter()
        {
            // Show form to create a new non-player character
            return View();
        }

        [HttpPost("npcs/create")]
        public IActionResult CreateNonPlayerCharacterPost()
        {
            // Handle creation of a new non-player character
            return RedirectToAction("NonPlayerCharacters");
        }

        [HttpGet("players/{id}/edit")]
        public IActionResult EditPlayerCharacter([FromRoute] int id)
        {
            // Show form to edit a player character
            return View();
        }

        [HttpPost("players/{id}/edit")]
        public IActionResult EditPlayerCharacterPost([FromRoute] int id)
        {
            // Handle editing a player character
            return RedirectToAction("PlayerCharacterDetails", new { id });
        }

        [HttpGet("npcs/{id}/edit")]
        public IActionResult EditNonPlayerCharacter([FromRoute] int id)
        {
            // Show form to edit a non-player character
            return View();
        }

        [HttpPost("npcs/{id}/edit")]
        public IActionResult EditNonPlayerCharacterPost([FromRoute] int id)
        {
            // Handle editing a non-player character
            return RedirectToAction("NonPlayerCharacterDetails", new { id });
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            // Show confirmation for deleting a character (PC or NPC)
            return View();
        }

        [HttpPost("{id}/delete")]
        public IActionResult DeleteConfirmed([FromRoute] int id)
        {
            // Handle deletion of a character (PC or NPC)
            return RedirectToAction("Index");
        }
    }

}
