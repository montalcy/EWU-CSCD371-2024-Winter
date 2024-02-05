using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class Base : IEntity
    {
        public  Guid Id { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public abstract string Name { get; init; }
    }
}
