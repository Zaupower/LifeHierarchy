using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.OrganismType
{
    //This implementation let the final class or child decide the implementations of the methods
    //Ohter wise it is possible to implement them on the correspondent parents class
    public abstract class Carnivore : Animal, ICarnivore
    {
        public abstract void Eat(Animal a);
    }
}
