using App1.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections;
using Microsoft.VisualBasic.FileIO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App1.Controllers
{
    public class CharacterController : Controller
    {
        private static AppDbContext context = new AppDbContext();

        public static List<Character> characters = new List<Character>();
            
        public IActionResult List()
        {
            List<Character> characters = context.Characters.ToList();
            return View(characters);
        }

        public IActionResult AddCharacter(Character character)
        {
            context.Characters.Add(character);
            context.SaveChanges();
            return View("List", context.Characters.ToList());
        }

        [HttpPost]
        public IActionResult EditForm(Character character)
        {
            if (ModelState.IsValid)
            {
                context.Characters.Remove(context.Characters.Find(character.ID));
                context.Characters.Update(character);
                context.SaveChanges();

                return View("List", context.Characters.ToList());
            }
            else
                return View();
        }

        [HttpGet]
        public IActionResult EditForm(int id)
        {
            return View(context.Characters.Find(id));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Character character = context.Characters.Find(id);
            context.Characters.Remove(character);
            context.SaveChanges();
            return View("List", context.Characters.ToList());
        }
    }
}

