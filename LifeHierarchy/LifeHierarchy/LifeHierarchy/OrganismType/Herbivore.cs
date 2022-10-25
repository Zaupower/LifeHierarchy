using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.OrganismType
{
    public abstract class Herbivore : Animal, IHerbivore
    {
        public abstract void Eat(Herbal a);
    }
}
