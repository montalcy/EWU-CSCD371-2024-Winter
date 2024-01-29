using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    private readonly IJokeService _jokeService;
    private readonly IJokeOutput _jokeOutput;

    public class Jester
    {
        private readonly IJokeService _jokeService;
        private readonly IJokeOutput _jokeOutput;

        public Jester(IJokeOutput jokeOutput, IJokeService jokeService)
        {
            this._jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
            this._jokeOutput = jokeOutput ?? throw new ArgumentNullException(nameof(jokeOutput));
        }

        public void TellJokey()
        {
            string joke = "";

            do
            {
                joke = _jokeService.GetJoke();
            } while ((JokeService.Contains("chuck norris", StringComparison.OrdinalIgnoreCase)));

            clown.PrintJokeyJoke(joke);
        }
    }
}
