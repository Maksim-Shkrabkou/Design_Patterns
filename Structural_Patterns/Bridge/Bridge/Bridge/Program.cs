using System;
using Bridge.Abstration_Bridge;
using Bridge.ClientCode;
using Bridge.Implementation_Bridge;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            
            Abstraction abstraction;
            
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);
            
            Console.WriteLine();
            
            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
    
}