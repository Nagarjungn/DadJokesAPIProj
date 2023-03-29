using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using unirest_net.http;

namespace DadJokesIO
{
    public class ConsumeAPI
    {
        public async Task GetRandomJokeAsync() 
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://dad-jokes.p.rapidapi.com/random/joke"),
                Headers =
    {
        { "X-RapidAPI-Key", "aafe91bdc7msh37acef50ff2cf14p135b45jsna4071280281b" },
        { "X-RapidAPI-Host", "dad-jokes.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        public async Task GetRandomJokeCountAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://dad-jokes.p.rapidapi.com/joke/count"),
                Headers =
    {
        { "X-RapidAPI-Key", "aafe91bdc7msh37acef50ff2cf14p135b45jsna4071280281b" },
        { "X-RapidAPI-Host", "dad-jokes.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
