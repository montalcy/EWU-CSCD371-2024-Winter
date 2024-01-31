using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;


public class Jester 
{
    
    private readonly IJokeOutput Output;
    private readonly IJokeService OurService;

    public Jester(IJokeService service, IJokeOutput output)
    {
        ArgumentNullException.ThrowIfNull(service);
        ArgumentNullException.ThrowIfNull(output);
        Output = output;
        OurService = service;
    }
   

    public void TellJoke()
    {
        string _theJoke;
        do
        {
          _theJoke = OurService.GetJoke();
        } while (_theJoke.Contains("Chuck Norris"));

        Output.PrintingJokeyJoke(_theJoke);
    }
    public void TellJoke(string JOKEY)
    {
        string _theJoke = JOKEY;
        do
        {
            _theJoke = OurService.GetJoke();
        } while (_theJoke.Contains("Chuck Norris"));

        Output.PrintingJokeyJoke(_theJoke);
    }
}
