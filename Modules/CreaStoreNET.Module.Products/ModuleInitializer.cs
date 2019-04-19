using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CreaStoreNET.Infrastructure; 

namespace CreaStoreNET.Module.Products
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
             
        }

     
        public void Configure(ApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
