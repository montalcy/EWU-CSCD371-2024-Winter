using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate;

public class Program
{
    public Action<string> WriteLine { get; set; } = System.Console.WriteLine;
    public Func<string?> ReadLine { get; set; } = System.Console.ReadLine;

    public Program() {}
    static void Main(string[] args)
    {
        Program Pro = new();
        Calculator Calcl = new();

        do
        {
            Pro.WriteLine("Enter your expression: ");
            string input = Pro.ReadLine();
        } while (!Calculator.TryCalculate(input, out var solution));

        Pro.WriteLine($"Answer: {solution}");

    }
}
