using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.Organism
{
    public class Grass : Herbal
    {
        public override void Name()
        {
            Console.Write(" Grass ");
        }

        public override void Species()
        {
            Console.Write(" Herbal ");
        }
    }
}
