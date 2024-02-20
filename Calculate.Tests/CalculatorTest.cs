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
        Calculator calc = new();
        int solution = calc.Add(2, 2);
        Assert.Equal(4, solution);
    }

    [Fact]
    public void Subtract_TwoValues_Successful()
    {
        Calculator calc = new();
        int solution = calc.Subtract(2, 2);
        Assert.Equal(0, solution);
    }

    [Fact]
    public void Divide_TwoValues_Successful()
    {
        Calculator calc = new();
        int solution = calc.Divide(2, 2);
        Assert.Equal(1, solution);
    }

    [Fact]
    public void Multiply_TwoValues_Successful()
    {
        Calculator calc = new();
        int solution = calc.Multiply(2, 2);
        Assert.Equal(4, solution);
    }

}
