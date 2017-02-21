﻿using Microsoft.AspNetCore.Hosting;

namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<StartUp>()
            .Build();

            host.Run();
        }
    }
}
