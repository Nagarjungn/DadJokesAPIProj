// See https://aka.ms/new-console-template for more information
using DadJokesIO;

Console.WriteLine("Hello, World!");

ConsumeAPI api = new ConsumeAPI();
await api.GetRandomJokeAsync();
await api.GetRandomJokeCountAsync();