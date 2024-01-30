using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;


public class Jester
{
   // readonly IJokeOutput? output;
   public IJokeOutput? Output {   get; set; }
   public IJokeService? OurService { get; set; }

    public Jester(IJokeService serve, IJokeOutput output)
    {
        ArgumentNullException.ThrowIfNull(serve, nameof(serve));
        ArgumentNullException.ThrowIfNull(output, nameof(output));
        this.Output=output;
        this.OurService=serve;
    }
    public static string GetJoke()
    {
        JokeService service = new();
        return service.GetJoke();

    }

    public void TellJoke()
    {
        string theJoke;

        do
        {
          theJoke=OurService!.GetJoke();
        } while ((!JokeService.Equals("chuck norris", StringComparison.OrdinalIgnoreCase)));

        Output!.PrintingJokeyJoke(theJoke);
    }
}
