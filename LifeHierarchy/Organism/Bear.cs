using LifeHierarchy.OrganismType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.Organism
{
    //Best aprouch so far, create an third class to bind another two
    public class Bear : Omnivore, IPredators
    {
        public override void Eat(Animal a)
        {
            Species();
            Name();
            Console.Write("Eating : ");

            a.Name();
        }
        public override void Eat(Herbal a)
        {
            Species();
            Name();
            Console.Write("Eating : ");
            a.Name();
        }

        public override void Name()
        {
            Console.Write(" Bear ");
        }

        public override void Species()
        {
            Console.Write(" Omnivore ");
        }
    }
}
