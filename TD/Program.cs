using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace TD
{
    public class Program
    {
        // root entrypoint (tmp AAAAARRRRRGGGGGG)
        // Although git commit -m "commit message" works just fine, it can be useful
        // dddddddddddddddddddd
        // hhhhhhhhhh
        // master commit 1
        // b2 change 1
        // bhjujhjh

        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}

