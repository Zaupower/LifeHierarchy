using LifeHierarchy.OrganismType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.Organism
{
    public class Wolf : Carnivore, IPredators
    {
        public Animal Eat()
        {
            throw new NotImplementedException();
        }

        public override void Species()
        {
            throw new NotImplementedException();
        }
    }
}
