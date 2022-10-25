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
        public override void Eat(Animal a)
        {
            Species();
            Name();
            Console.Write("Eating : ");

            a.Name();
        }

        public override void Name()
        {
            Console.Write(" Wolf "); ;
        }

        public override void Species()
        {
            Console.Write(" Carnivore and Predator ");
        }
    }
}
