using HttpTest.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpTest.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public PokemonRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Stream> GetPokemon(string pokemonName)
        {

            var request = new HttpRequestMessage(HttpMethod.Get,
            $"https://pokeapi.co/api/v2/pokemon/{pokemonName}");

            //request.Headers.Add("Accept", "application/json");
            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            //Dictionary<string, string> httpParameters = new Dictionary<string, string>
            //{
            //    {
            //        "PokemonName", pokemonName
            //    }
            //};

            //request.Content = new FormUrlEncodedContent(httpParameters);

            HttpClient client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            return await response.Content.ReadAsStreamAsync();
        }
    }
}
