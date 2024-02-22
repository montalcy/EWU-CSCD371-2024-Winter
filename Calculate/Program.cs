using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate;

public class Program
{
    public Action<string> WriteLine { get; init; } = System.Console.WriteLine;
    public Func<string?> ReadLine { get; init; } = System.Console.ReadLine;

    public Program() { }
    public static void Main()
    {
        Program Pro = new();
        Calculator calc = new();
        int solution;
        string input;

        do
        {
            Pro.WriteLine("Enter your expression: ");
            input = Pro.ReadLine()!;

            if (calc.TryCalculate(input, out solution))
            {
                Pro.WriteLine($"Answer: {solution}");
            }

        } while (input == null || !calc.TryCalculate(input, out solution));


    }
}
