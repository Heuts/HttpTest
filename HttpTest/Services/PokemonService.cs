using HttpTest.Repositories.Interfaces;
using HttpTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpTest.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonService(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<Stream> GetPokemon(string pokemonName)
        {
            return await _pokemonRepository.GetPokemon(pokemonName);
        }
    }
}
