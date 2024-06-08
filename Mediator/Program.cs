namespace Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        Component1 component1 = new();
        Component2 component2 = new();
        new ConcreteMediator(component1, component2);

        Console.WriteLine("Client triggers operation A.");
        component1.DoA();

        Console.WriteLine();

        Console.WriteLine("Client triggers operation D.");
        component2.DoD();
    }
}
