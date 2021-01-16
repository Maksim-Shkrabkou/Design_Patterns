using System;
using Composite.Client;
using Composite.CompositePattern;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientCode();

            // This way the client code can support the simple leaf
            // components...
            var leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCompositeCode(leaf);

            // ...as well as the complex composites.
            var tree = new CompositePattern.Composite();
            var branch1 = new CompositePattern.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            var branch2 = new CompositePattern.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCompositeCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCompositeCode2(tree, leaf);
        }
    }
}