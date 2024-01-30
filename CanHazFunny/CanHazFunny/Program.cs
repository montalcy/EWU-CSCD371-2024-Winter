using System;
namespace CanHazFunny;

public class Program
{
    public static void Main(string[] args)
    {
       
        new Jester( new JokeService(), new OutputtingJoke()).TellJoke();

        
        //Feel free to use your own setup here - this is just provided as an example
        //new Jester( new SomeReallyCoolOutputClass(), new SomeJokeServiceClass() ).TellJoke();
    }
}
