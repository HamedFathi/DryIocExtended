using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DryIoc.Microsoft.DependencyInjection
{
    public static class DryIocExtensions
    {
        public static IHostBuilder UseDryIoc(this IHostBuilder hostBuilder, IServiceProviderFactory<IContainer> factory = null)
        {
            return hostBuilder.UseServiceProviderFactory(factory ?? new DryIocServiceProviderFactory());
        }
    }
}
