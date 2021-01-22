using System;
using Command.CommandPattern;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            var invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            var receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
            
            
            Console.WriteLine('\n');

            // Initialization pattern for Command
            var receiver2 = new Receiver();
            var simpleCommand2 = new SimpleCommand("Say Hi2");
            var complexCommand2 = new ComplexCommand(receiver: receiver2, "Send email2", "Save report2");
            var invoker2 = new Invoker();
            invoker2.SetOnStart(simpleCommand2);
            invoker2.SetOnFinish(complexCommand2);
            invoker2.DoSomethingImportant();
        }
    }
}