using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate;
public class Calculator
{
    public IReadOnlyDictionary<char, Func<int, int, int>> MathematicalOperations { get; } = new Dictionary<char, Func<int, int, int>>
    {
        { '+', Add},
        { '-' , Subtract },
        { '/', Divide },
        {'*', Multiply }
    };

    public static int Add(int firstValue, int secondValue) => firstValue + secondValue;

    public static int Subtract(int firstValue, int secondValue) => firstValue - secondValue;
    public static int Multiply(int firstValue, int secondValue) => (firstValue * secondValue);
    public static int Divide(int firstValue, int secondValue) => secondValue != 0 ? (firstValue / secondValue) : throw new ArgumentException("Cant divide by zero");

    public bool TryCalculate(string expression, out int solution)
    {
        solution = 0;
        string[] inputs= expression.Split(' ');
        if (inputs.Length != 3) return false;
        if (!int.TryParse(inputs[0], out int firstint)) return false;
        if (!int.TryParse(inputs[1], out int secondint)) return false;
        if (MathematicalOperations.TryGetValue(inputs[1][0], out Func<int, int, int>? operand))
        {
            solution = operand((int)firstint, (int)secondint);
            return true;
        }
        return false;
    }
}

/*
- Define a Calculator class ❌✔
- Implement a `TryCalculate` method following "TryParse" pattern ❌✔
- Valid `calculation` expressions include such strings as "3 + 4", "42 - 2", etc. ❌✔
- If there is no whitespace around the operator, you can assume the `calculation` is invalid and return false. Similarly if the operands are not integers. ❌✔
- Use `string.Split()`, pattern matching, logical and operators to parse the string in their entirety ❌✔
- Index into the `MathematicalOperations` method using the operator parsed during pattern matching to find the corresponding implementation and invoke it. ❌✔
- Implement the Program class to instantiate the calculator and invoke it based on user input from the console. ❌✔
- Be sure to use the `WriteLine`/`ReadLine` properties on `Program` for testing the input and output of your program. 
*/