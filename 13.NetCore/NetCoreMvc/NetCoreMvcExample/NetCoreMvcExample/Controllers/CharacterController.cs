using Microsoft.AspNetCore.Mvc;
using NetCoreMvcExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcExample.Controllers
{
    public class CharacterController : Controller
    {
        private ICharactersRepository _charactersRepository;

        public CharacterController(ICharactersRepository charactersRepository)
        {
            _charactersRepository = charactersRepository;
        }


        public IActionResult Index()
        {
            ViewData["Character"] = _charactersRepository.GetCharacters().FirstOrDefault();
            return View();
        }

        public async Task<IActionResult> GetSingle()
        {
            ViewData["Character"] = await _charactersRepository.GetSingleCharacter();
            return View();
        }
    }
}