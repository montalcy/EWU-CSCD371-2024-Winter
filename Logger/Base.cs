using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public abstract record class Base : IEntity
{
    Guid IEntity.Id { get; init; } // Explicitly Implemented as some derived classes didn't have a use for it
    public abstract string Name { get; set; } // Implicitly implemented, forced implementation using abstracted
}

