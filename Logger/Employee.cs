using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Employee : Base
    {
        public Employee() { }
        public Employee(int id) { }
        public Employee(int id, string name) { }
        public Employee(string name) { }
        public Employee(string name, int id) { }
        public override string Name => getEmployeeName();

        private string getEmployeeName()
        {
            throw new NotImplementedException();
        }
    }
}
