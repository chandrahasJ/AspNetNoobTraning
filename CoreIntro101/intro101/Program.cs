using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using GoingToWeb;

namespace intro101
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string Name = "";
            Console.WriteLine("Type your Name:> ");
            Name = Console.ReadLine();

            //String Interpolation....
            Console.WriteLine($"Hello {Name}."); */
            var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .Build();

                host.Run();
        }
    }
}
