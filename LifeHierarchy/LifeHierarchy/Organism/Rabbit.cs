using LifeHierarchy.OrganismType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.Organism
{
    public class Rabbit : Herbivore
    {
        public override void Eat(object o)
        {
            throw new NotImplementedException();
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
            Console.Write(" Rabbit ");
        }

        public override void Species()
        {
            Console.Write(" Herbivore ");
        }
    }
}
