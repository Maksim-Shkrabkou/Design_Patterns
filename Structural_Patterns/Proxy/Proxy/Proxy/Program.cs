using System;
using Proxy.Client;
using Proxy.ProxyPattern;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientCode();
            
            Console.WriteLine("Client: Executing the client code with a real subject:");
            var realSubject = new RealSubject();
            client.ClientProxyCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            var proxy = new ProxyPattern.Proxy(realSubject);
            client.ClientProxyCode(proxy);
        }
    }
}