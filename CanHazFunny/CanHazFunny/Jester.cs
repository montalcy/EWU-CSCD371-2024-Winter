using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;


public class Jester 
{
    private const string NameToAvoid = "chuck norris";
    string theJoke = "";

    // readonly IJokeOutput? output;
    private IJokeOutput? Output;
    private IJokeService? OurService;

    public Jester(IJokeService service, IJokeOutput output)
    {
        ArgumentNullException.ThrowIfNull(service);
        ArgumentNullException.ThrowIfNull(output);
        this.Output = output;
        this.OurService = service;
    }
   

    public void TellJoke()
    {  
        do
        {
          theJoke = OurService!.GetJoke();
        } while (theJoke.Contains(NameToAvoid, StringComparison.OrdinalIgnoreCase));

        Output!.PrintingJokeyJoke(theJoke);
    }
}
