using BudgetApp.Abstractions;
using BudgetApp.Classes;
using BudgetApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace BudgetApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IServiceProvider? Services { get; private set; }
    public static IConfiguration? Configuration { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();

        ConfigureServices(services);

        Services = services.BuildServiceProvider();

        var loginView = Services.GetRequiredService<LoginView>();
        loginView.Show();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        var connectionString = Configuration!.GetConnectionString("DefaultConnection");

        services.AddDbContext<BudgetDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IRepository<User>, Repository<User>>();

        services.AddTransient<LoginView>();
    }
}
