using System;
using Madiator.MediatorPattern;

namespace Madiator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var component1 = new Component1();
            var component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}