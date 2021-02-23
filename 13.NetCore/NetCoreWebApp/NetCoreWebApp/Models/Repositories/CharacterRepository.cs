using NetCoreWebApp.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp.Models.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        public List<Character> GetCharacters()
        {
            var context = new NetCoreWebAppContext();
            return context.Characters.ToList();
        }
    }
}
