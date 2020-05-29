using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HttpTest.Repositories.Interfaces
{
    public interface IPokemonRepository
    {
        Task<Stream> GetPokemon(string pokemonName);
    }
}
