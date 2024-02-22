using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Calculate.Tests;

public class CalculatorTest
{
    [Fact]
    public void Add_TwoValues_Successful()
    {
        int solution = Calculator.Add(2, 2);
        Assert.Equal(4, solution);
    }

    [Fact]
    public void Subtract_TwoValues_Successful()
    {
        int solution = Calculator.Subtract(2, 2);
        Assert.Equal(0, solution);
    }

    [Fact]
    public void Divide_TwoValues_Successful()
    {
        int solution = Calculator.Divide(2, 2);
        Assert.Equal(1, solution);
    }

    [Fact]
    public void Multiply_TwoValues_Successful()
    {
        int solution = Calculator.Multiply(2, 2);
        Assert.Equal(4, solution);
    }

    [Fact]
    public void Divide_ByZero_Fails()
    {
        Assert.Throws<ArgumentException>(() => Calculator.Divide(2, 0));
    }

    [Fact]
    public void TryCalculate_ByZero_Fails()
    {
        int res;
        Calculator calc = new();
        Assert.Throws<ArgumentException>(() => calc.TryCalculate("2 / 0", out res));
    }

    [Theory]
    [InlineData(3, "1 + 2")]
    [InlineData(4, "2 + 2")]
    [InlineData(0, "2 - 2")]
    [InlineData(1, "3 / 3")]
    [InlineData(9, "3 * 3")]
    public void TryCalculate_GivenValidDifferentInputs_Success(int expect, string expression)
    {
        int res;
        Calculator calculator = new();
        calculator.TryCalculate(expression, out res);
        Assert.Equal(expect, res);
        Assert.True(calculator.TryCalculate(expression, out res));
    }

    [Fact]
    public void TryCalculate_GivenInvalidInputs_FalseSuccess()
    {
        int res;
        Calculator calculator = new();
        Assert.False(calculator.TryCalculate("2 &", out res));
        Assert.False(calculator.TryCalculate("2 + 3 + 4 + 6", out res));
    }

    [Theory]
    [InlineData('$')]
    [InlineData('#')]
    [InlineData('@')]
    [InlineData('T')]
    [InlineData('1')]

    public void MathematicalOperation_GivenInvalidInputs_DoesNotContainSuccess(char operation)
    {
        Calculator calculator = new();
        IReadOnlyDictionary<char, Func<int, int, int>> operations = calculator.MathematicalOperations;
        Assert.DoesNotContain(operation, operations);
    }

    [Theory]
    [InlineData('/')]
    [InlineData('*')]
    [InlineData('+')]
    [InlineData('-')]
    public void MathematicalOperation_GivenValidInputs_DoesContainSuccess(char operation)
    {
        Calculator calculator = new();
        IReadOnlyDictionary<char, Func<int, int, int>> operations = calculator.MathematicalOperations;
        Assert.Contains(operation, operations);
    }

}
