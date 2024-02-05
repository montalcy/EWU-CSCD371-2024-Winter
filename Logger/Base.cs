using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class Base : IEntity
    {
        private Guid id;

        public Guid Id { get => id; init => id = value; } // Implemented Implicitly as every type of children will have an ID associated with them
        public abstract string Name { get; init; } // Implemented abstractly as to force children to implement it
    }
}
