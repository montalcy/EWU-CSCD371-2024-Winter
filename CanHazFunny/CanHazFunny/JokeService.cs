using System;
using System.Net.Http;

namespace CanHazFunny;

public class JokeService : IJokeService
{
    private HttpClient HttpClient { get; } = new();

    public string GetJoke()
    {
        //HttpResponseMessage response = HttpClient.GetAs).Result;
        string joke = HttpClient.GetStringAsync("https://geek-jokes.sameerkumar.website/api").Result;
           return joke;
       // }
       /// catch (AggregateException e)
       // {

       // }
       //string joke=response.Content.ReadAsStringAsync().Result;
       //return joke;
    }

}
