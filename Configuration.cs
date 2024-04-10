using FinConnectWinFormsTest.Sorters;
using Microsoft.Extensions.DependencyInjection;

namespace FinConnectWinFormsTest
{
    internal class Configuration
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<ISorterForNewFormats, SorterForNewFormats>();
            services.AddTransient<ISorterForXls, SorterXlsFormat>();

            services.AddTransient<Form1>();

            return services.BuildServiceProvider();
        }
    }
}
