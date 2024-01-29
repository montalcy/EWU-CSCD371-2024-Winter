using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester : IJokeService, IJokeOutput
    {
        public string GetJoke()
        {
            throw new NotImplementedException();
        }


        public void PrintJokeyJoke(string jokesToPrint)
        {
            Console.WriteLine(jokesToPrint);
        }
        public void TellJoke(string joke)
        {
            JokeService service = new();
            Jester clown = new();

            do
            {
                joke = service.GetJoke();
            } while ((!JokeService.Equals("chuck norris", StringComparison.OrdinalIgnoreCase)));

            clown.PrintJokeyJoke(joke);
        }
    }
}
