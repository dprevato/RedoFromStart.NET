using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Core;
using Serilog.Events;
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
        SetLogConfiguration();

        Log.Information("Initialization starts");
        ApplicationConfiguration.Initialize();
        var splashContext = new SplashFadeAppContext(new MainView(), new Splash());

        splashContext.DoFadeOpen = true;
        splashContext.DoFadeClose = true;
        splashContext.SecondsSplashShown = 3;

        try {
            Application.Run(splashContext);
        }
        catch (Exception ex) {
            Log.Error(ex, "Something went wrong");
        }
        finally {
            Log.CloseAndFlush();
        }
    }

    private static IServiceProvider ConfigureServices() {
        var services = new ServiceCollection();

        // Registrazione servizi

        return services.BuildServiceProvider();
    }

    private static void SetLogConfiguration() {
        const string connectionString = @"Host=127.0.0.1;Username=root;Password=next;Database=SerilogTest";
        const string tableName = "RedoFromStartLog";

        Log.Logger = new LoggerConfiguration()
                     .Enrich.With(new ThreadIdEnricher())
                     .Enrich.WithEnvironmentUserName()
                     .MinimumLevel.Debug()
                     .WriteTo.Console(outputTemplate: "{Timestamp HH:mm} [{Level}] ({ThreadId}) [{EnvironmentUserName}] {Message}{NewLine}{Exception}")
                     .WriteTo.File("logs/RedoFromStartLog.txt", rollingInterval: RollingInterval.Day, outputTemplate: "{Timestamp HH:mm} [{Level}] ({ThreadId}) [{EnvironmentUserName}] {Message}{NewLine}{Exception}")
                     .WriteTo.MySQL(connectionString, tableName: tableName, LogEventLevel.Debug, batchSize: 1)
                     .CreateLogger();
    }
}

internal class ThreadIdEnricher : ILogEventEnricher
{
    #region Implementation of ILogEventEnricher

    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory) {
        logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("ThreadId", Thread.CurrentThread.ManagedThreadId));
    }

    #endregion
}