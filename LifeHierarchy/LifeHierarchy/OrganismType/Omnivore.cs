﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHierarchy.OrganismType
{
    public class Omnivore : Herbivore, ICarnivore
    {
        public void Eat(Animal a)
        {
            throw new NotImplementedException();
        }
    }
}