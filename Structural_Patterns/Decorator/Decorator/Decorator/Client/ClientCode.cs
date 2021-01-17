using System;
using Decorator.DecoratorPattern;

namespace Decorator.Client
{
    // The client code works with all objects using the Component interface.
    // This way it can stay independent of the concrete classes of
    // components it works with.
    public class ClientCode
    {
        public void ClientDecoratorCode(IComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}