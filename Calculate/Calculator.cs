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
        string[] inputs = expression.Split(' ');
        if (inputs.Length != 3) return false;
        if (!int.TryParse(inputs[0], out int firstint)) return false;
        if (!int.TryParse(inputs[2], out int secondint)) return false;
        if (MathematicalOperations.TryGetValue(inputs[1][0], out Func<int, int, int>? operand))
        {
            solution = operand((int)firstint, (int)secondint);
            return true;
        }
        return false;
    }
}
