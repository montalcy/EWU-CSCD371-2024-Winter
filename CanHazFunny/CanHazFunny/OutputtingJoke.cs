using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;

public class OutputtingJoke : IJokeOutput
{
    public void PrintingJokeyJoke(string jokeToPrint)
    {
        ArgumentNullException.ThrowIfNull(jokeToPrint);
        Console.WriteLine(jokeToPrint);
    }
}
