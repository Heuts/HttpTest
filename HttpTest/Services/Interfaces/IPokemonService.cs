using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HttpTest.Services.Interfaces
{
    public interface IPokemonService
    {
        Task<Stream> GetPokemon(string pokemonName);
    }
}
