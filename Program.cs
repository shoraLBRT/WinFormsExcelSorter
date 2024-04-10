using Microsoft.Extensions.DependencyInjection;

namespace FinConnectWinFormsTest
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = new Configuration().ConfigureServices();

            using var startForm = serviceProvider.GetService<Form1>()!;

            Application.Run(startForm);
        }
    }
}