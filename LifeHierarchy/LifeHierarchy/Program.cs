

using LifeHierarchy;
using LifeHierarchy.Organism;
using LifeHierarchy.OrganismState;
using LifeHierarchy.OrganismType;

class Program
{
    static void Main(string[] args)
    {

        Bear bear = new Bear();
        Wolf wolf = new Wolf();
        Rabbit rabbit = new Rabbit();

        Grass grass = new Grass(); 
        Rose rose = new Rose();

        Console.WriteLine("");
        Console.WriteLine("livingThing");
        var livingThing = new Alive[] { bear, wolf, rabbit, grass, rose };
        foreach (var thing in livingThing)
        {
            thing.Species();
        }

        Console.WriteLine(" ");
        Console.WriteLine("animals");

        var animals = new Animal[] { rabbit, bear, wolf };
        foreach (var animal in animals)
        {
            animal.Name();
        }

        Console.WriteLine("");
        Console.WriteLine("herbivores");

        var herbivores = new IHerbivore[] { rabbit, bear };
        foreach (var herbivore in herbivores)
        {
            herbivore.Eat(grass);
            Console.WriteLine("");
        }


        Console.WriteLine("");
        Console.WriteLine("herbals");
        var herbals = new Herbal[] { rose, grass };
        foreach (var herbal in herbals)
        {
            herbal.Name();
        }

        Console.WriteLine("");
        Console.WriteLine("predators");
        var predators = new IPredators[] { wolf, bear };

        foreach (var predator in predators)
        {
            predator.Eat(rabbit);
            Console.WriteLine("");
        }
    }
}