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
        public override void Eat(object o)
        {
            throw new NotImplementedException();
        }

        public override void Name()
        {
            Console.WriteLine("Wolf"); ;
        }

        public override void Species()
        {
            Console.WriteLine("Carnivore and Predator");
        }
    }
}
