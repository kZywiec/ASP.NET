using App1.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections;
using Microsoft.VisualBasic.FileIO;

namespace App1.Controllers
{
    public class CharacterController : Controller
    {
        public static List<Character> characters = new List<Character> {
            new Character()
            {
                ID = 0, 
                Name = "Geralt",
                Sex = "Male",
                Age=112, 
                Race = "Witcher" 
            },

            new Character()
            {
                ID = 1, 
                Name = "Yennefer",
                Sex = "Female",
                Age=85,
                Race = "Human"
            },

            new Character()
            {
                ID = 2, 
                Name = "Zoltan Chivay",
                Sex = "Male",
                Age=62,
                Race = "Dwarf"
            }
        };

        public static int counter = characters.Count();

        public IActionResult List()
        {
            return View(characters);
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Character_Form() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Character_Form(Character character)
        {
            return View();
        }


        [HttpPost]
        public IActionResult EditForm(Character character)
        {
            if (ModelState.IsValid)
            {
                characters[character.ID] = character;
                return View("List", characters);
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult EditForm(int id)
        {
            return View(characters[id]);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            characters.RemoveAt(id);
            return View("List", characters);
        }
    }
}
