using LifeHierarchy.OrganismState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy
{
    public abstract class Animal : Alive
    {
        public abstract void Eat(Object o);
        public abstract void Name();
    }
}
