using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class ContinentFactory

    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
