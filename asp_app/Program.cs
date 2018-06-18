﻿using System;
using System.Collections.Generic;
using System.IO;
using ComputingService.Services.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ComputingService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
	            .ConfigureLogging(builder => builder.AddCustomLoggers())
                .UseStartup<Startup>()
                .Build();
    }
}
