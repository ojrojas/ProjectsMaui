namespace MauiDataSqlite;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

        var path = Path.Combine(FileSystem.AppDataDirectory, "mauisqlitedb.db3");

        builder.Services.AddDbContext<MauiSqliteDbContext>(options => options.UseSqlite($"Data Source={path}"));
        builder.Services.AddBlazoredToast();
        builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddTransient<IWorkService, WorkService>();
        builder.Services.AddTransient<ICategoryService, CategoryService>();
        builder.Services.AddTransient<InitializerDbContext>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        var app = builder.Build();
        using var scope = app.Services.CreateScope();
        var service = scope.ServiceProvider;
        var initializer = service.GetRequiredService<InitializerDbContext>();
        initializer.Run();

        return app;
    }
}
