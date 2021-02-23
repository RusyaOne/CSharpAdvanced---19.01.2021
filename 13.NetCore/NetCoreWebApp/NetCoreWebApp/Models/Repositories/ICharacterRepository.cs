using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp.Models.Repositories
{
    public interface ICharacterRepository
    {
        List<Character> GetCharacters();
    }
}
