using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void EmployeeConstructor_CheckingEquality_Equal()
        {
            //should return true since they are the same type of records

            Base et1 = new Employee("First", "Last", null);
            Base et2 = new Employee("First2", "Last2", null);
            Assert.Equal(et1.GetType(), et2.GetType());

        }

        [Fact]
        public void EmployeeConstructor_CheckingEquality_NotEqual()
        {
            //should return true since they are the same type of records

            Base et1 = new Employee("First", "Last", null);
            Base et2 = new Student("First2", "Last2", null);
            Assert.NotEqual(et1.GetType(), et2.GetType());

        }

    }
}
