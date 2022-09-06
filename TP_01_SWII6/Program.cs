
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_01_SWII6;

namespace TP_01_SWII6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new BookTest();
            new BookRepositoryCSV();

            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}
