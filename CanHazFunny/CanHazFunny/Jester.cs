using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;


public class Jester
{
    // readonly IJokeOutput? output;
    private OutputtingJoke? Output;
    private JokeService? OurService;

    public Jester(JokeService? serve, OutputtingJoke? output)
    {
        ArgumentNullException.ThrowIfNull(serve, nameof(serve));
        ArgumentNullException.ThrowIfNull(output, nameof(output));
        this.Output=output;
        this.OurService=serve;
    }
   

    public void TellJoke()
    {
        string theJoke;

        do
        {
          theJoke=OurService!.GetJoke();
        } while ((!theJoke.Equals("chuck norris", StringComparison.OrdinalIgnoreCase)));

        Output!.PrintingJokeyJoke(theJoke);
    }
}
