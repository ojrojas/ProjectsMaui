namespace MauiDataStoreSqlite;

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

        var path = Path.Combine(FileSystem.AppDataDirectory, "mauisqliteexample.db3");

        builder.Services.AddMauiBlazorWebView();

        builder.Services.AddSingleton<IGroupRepository>(
            scope => ActivatorUtilities.CreateInstance<GroupRepository>(
                scope, path));
        builder.Services.AddSingleton<ITaskRepository>(
            scope => ActivatorUtilities.CreateInstance<TaskRepository>(
                scope, path));

        builder.Services.AddSingleton<IGroupService, GroupService>();
        builder.Services.AddSingleton<ITaskService, TaskService>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
