using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public abstract record class Base : IEntity
{
    public Guid Id { get; init; }
    public abstract string Name { get; set; } // implicitly implemented, forced implementation using abstracted
}

