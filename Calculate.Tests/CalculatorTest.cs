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

    //[Fact]
    //public void TryCalculateWithValidInputEquals()
    //{
    //    Calculator cals = new();
    //    cals.TryCalculate("2 + 3", out int answer);
    //    Assert.Equal(5, answer);
    //}
}
