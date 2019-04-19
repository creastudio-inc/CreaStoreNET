using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using CreaStoreNET.Infrastructure;
using CreaStoreNET.Module.Core.Models;
using CreaStoreNET.Module.Core.Services;

namespace CreaStoreNET.Module.Core
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<SignInManager<User>, SignInManager<User>>();
            serviceCollection.AddScoped<UserManager<User>, UserManager<User>>();
        }

     
        public void Configure(ApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
