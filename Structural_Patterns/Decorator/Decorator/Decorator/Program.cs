using System;
using Decorator.Client;
using Decorator.DecoratorPattern;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientCode();
            
            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientDecoratorCode(simple);
            Console.WriteLine();
            
            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            var decorator1 = new ConcreteDecoratorA(simple);
            var decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientDecoratorCode(decorator2);
        }
    }
}