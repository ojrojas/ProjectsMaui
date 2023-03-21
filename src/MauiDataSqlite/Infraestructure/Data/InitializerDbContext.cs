namespace MauiDataSqlite.Infraestructure.Data;

public class InitializerDbContext
{
    private readonly MauiSqliteDbContext _context;
    private readonly ILogger<InitializerDbContext> _logger;

    public InitializerDbContext(MauiSqliteDbContext context, ILogger<InitializerDbContext> logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void Run()
    {
#if DEBUG
        _logger.LogInformation("Ensure delete database");
        _context.Database.EnsureDeleted();
#endif
        _logger.LogInformation("Ensure create database");
        _context.Database.EnsureCreated();
        CreateData();
    }

    private void CreateData()
    {
        _context.Categories.AddRange(
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "MyToday",
                CreatedOn = DateTime.UtcNow,
                Page = "/"
            },
            new Category
            {
                Name = "Example Page",
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                Page ="/Categories/CategorySelected"
            }) ;
        _context.SaveChanges();
    }
}

