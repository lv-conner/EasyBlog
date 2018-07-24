using EasyBlog.IServices;
using EasyBlog.IServices.DefaultServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DefaultServiceExtension
    {
        public  static IServiceCollection AddMemoryAccountServices(this IServiceCollection services)
        {
            services.AddSingleton<IAccountServices, MemoryAccountServices>();
            return services;
        }
    }
}
