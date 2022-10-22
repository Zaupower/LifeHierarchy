using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.Organism
{

    internal class Rose : Herbal
    {
        public override void Name()
        {
            Console.Write(" Rose ");
        }

        public override void Species()
        {
            Console.Write(" Herbivore ");
        }
    }
}
