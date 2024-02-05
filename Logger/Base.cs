﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class Base : IEntity
    {
        public Guid Id { get; init; }
        string IEntity.Name { get => getName(); set => setName(value); }
        
        public abstract string getName();
        public abstract void setName(string name);

       
    }
}
