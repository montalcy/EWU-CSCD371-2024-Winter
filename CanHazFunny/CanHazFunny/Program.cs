using System;
namespace CanHazFunny;

public class Program
{
    static void Main(String []args)
    {
        JokeService jokeService = new JokeService();
        OutputtingJoke outputtingJoke = new OutputtingJoke();
        Jester j=new Jester(jokeService, outputtingJoke);
        j.TellJoke();
        
        //Feel free to use your own setup here - this is just provided as an example
        //new Jester( new SomeReallyCoolOutputClass(), new SomeJokeServiceClass() ).TellJoke();
    }
}
