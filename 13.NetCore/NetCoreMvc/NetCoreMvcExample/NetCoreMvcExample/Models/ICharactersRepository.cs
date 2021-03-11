using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcExample.Models
{
    public interface ICharactersRepository
    {
        IEnumerable<Character> GetCharacters();
        Task<Character> GetSingleCharacter();
        void WriteCharacterToFile();
    }
}