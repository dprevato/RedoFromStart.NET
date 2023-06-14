using Microsoft.Extensions.DependencyInjection;
using UI.Views;

namespace UI;

internal static class Program
{
    public static IServiceProvider Services { get; private set; }  // Questa property non può rimanere null

    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Services = ConfigureServices();

        ApplicationConfiguration.Initialize();
        var splashContext = new SplashAppContext(new MainForm(), new Splash());
        Application.Run(splashContext);
        //Application.Run(new Form1());
    }

    private static IServiceProvider ConfigureServices() {
        var services = new ServiceCollection();

        // Registrazione servizi

        return services.BuildServiceProvider();
    }


}