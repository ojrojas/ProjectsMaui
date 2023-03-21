namespace MauiDataSqlite.Infraestructure.Data;

public class MauiSqliteDbContext : DbContext
{
    public MauiSqliteDbContext(DbContextOptions<MauiSqliteDbContext> options) : base(options) { }


    public DbSet<Category> Categories { get; set; }
    public DbSet<Work> Works { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}

