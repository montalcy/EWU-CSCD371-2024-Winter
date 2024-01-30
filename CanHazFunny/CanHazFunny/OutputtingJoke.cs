using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class OutputtingJoke : IJokeOutput
    {
        public void PrintingJokeyJoke(string jokeToPrint)
        {
            if (jokeToPrint == null)
                throw new ArgumentNullException("joke is Null");
            Console.WriteLine(jokeToPrint);
        }
    }
}
