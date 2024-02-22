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
    public void AddTwoValuesSuccessful()
    {
        int solution = Calculator.Add(2, 2);
        Assert.Equal(4, solution);
    }

    [Fact]
    public void SubtractTwoValuesSuccessful()
    {
        int solution = Calculator.Subtract(2, 2);
        Assert.Equal(0, solution);
    }

    [Fact]
    public void DivideTwoValuesSuccessful()
    {
        int solution = Calculator.Divide(2,2);
        Assert.Equal(1, solution);
    }

    [Fact]
    public void MultiplyTwoValuesSuccessful()
    {
        int solution = Calculator.Multiply(2, 2);
        Assert.Equal(4, solution);
    }

    [Fact]
    public void DivideByZeroFails()
    {
        Assert.Throws<ArgumentException>(()=> Calculator.Divide(2, 0));
    }

    [Fact]
    public void TryCalculateByZeroFails()
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
    public void TryCalculateGivenValidInputs(int expect, string expression)
    {
        int res;
        Calculator calculator = new();
        calculator.TryCalculate(expression, out res);
        Assert.Equal(expect, res);
        Assert.True(calculator.TryCalculate(expression, out res));
    }

    [Fact]
    public void TryCalculateGivenInvalidInputs()
    {
        int res;
        Calculator calculator = new();
        Assert.False(calculator.TryCalculate("2 &", out res));
    }

}
