﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

namespace WebOptimizer.Test
{
    public class HostingEnvironment : IWebHostEnvironment
    {
        public string EnvironmentName { get; set; }
        public string ApplicationName { get; set; }
        public string WebRootPath { get; set; }
        public IFileProvider WebRootFileProvider { get; set; }
        public string ContentRootPath { get; set; }
        public IFileProvider ContentRootFileProvider { get; set; }
    }
}
