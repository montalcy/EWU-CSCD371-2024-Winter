using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests
{
    public class PersonTests
    {
        [Fact]
        public void GetFullName_TwoRecords_NotEqual()
        {
            //should return false since they are different records
            FullName full = new("First", "Last");
            FullName otherFull = new("Last", "Last");

            Assert.NotEqual(otherFull.GetFullName(), full.GetFullName());
        }

        [Fact]
        public void GetFullName_TwoRecords_Equal()
        {
            //should return false since they are different records

            Student s1 = new("First", "Last", null);
            Student s2 = new("First", "Last", null);

            Employee e1 = new("First", "Last", null);
            Employee e2 = new("First", "Last", null);

            Book book1 = new("Title");
            Book book2 = new("Title");

            Assert.Equal(s1.Name, s2.Name);
            Assert.Equal(e1.Name, e2.Name);
            Assert.Equal(book1.Name, book2.Name);
        }
    }
}
