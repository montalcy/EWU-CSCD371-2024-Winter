using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculate;

public class CalculateTests
{
    [Fact]
    public void Add_TwoValues_Successful()
    {
        int solution= Calculator.Add(2, 2);
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


}


