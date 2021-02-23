using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ICharacterRepository characterRepository;

        public HomeController(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }

        public string Index()
        {
            return characterRepository.GetCharacters().FirstOrDefault().FirstName;
        }

        public ViewResult Data()
        {
            ViewData["character"] = characterRepository.GetCharacters().FirstOrDefault();
            return View();
        }

        public ViewResult All()
        {
            ViewData["Characters"] = characterRepository.GetCharacters();
            return View();
        }
    }
}
