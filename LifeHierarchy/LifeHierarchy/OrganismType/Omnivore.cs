using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.OrganismType
{
    public abstract class Omnivore : Animal, IHerbivore, ICarnivore
    {
        public abstract void Eat(Herbal a);
        public abstract void Eat(Animal a);
    }
}
