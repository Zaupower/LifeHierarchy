

using LifeHierarchy;
using LifeHierarchy.Organism;

class Program
{
    static void Main(string[] args)
    {

        Bear b = new Bear();
        Wolf w = new Wolf();
        Rabbit r = new Rabbit();

        var ip = new IPredators[] { w };

        foreach (var predator in ip)
        {
            predator.Eat(r);
        }
    }
}