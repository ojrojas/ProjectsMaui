namespace MauiDataStoreSqlite.Core.Repositories;

public class TaskRepository : Repository, ITaskRepository
{
    private readonly ILogger<TaskRepository> _logger;

    public TaskRepository(ILogger<TaskRepository> logger, string dpath) : base(logger, dpath)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async ValueTask<IEnumerable<MauiDataStoreSqlite.Core.Entities.Task>> GetAllTaskAsync(CancellationToken cancellationToken)
    {
        return await GetAllAsync<MauiDataStoreSqlite.Core.Entities.Task>(cancellationToken);
    }

    public async ValueTask<MauiDataStoreSqlite.Core.Entities.Task> CreateTaskAsync(MauiDataStoreSqlite.Core.Entities.Task task, CancellationToken cancellationToken)
    {
        return await CreateAsync(task, cancellationToken);
    }

    public async ValueTask<MauiDataStoreSqlite.Core.Entities.Task> UpdateTaskAsync(MauiDataStoreSqlite.Core.Entities.Task task, CancellationToken cancellationToken)
    {
        return await UpdateAsync<MauiDataStoreSqlite.Core.Entities.Task>(task, cancellationToken);
    }

    public async ValueTask<MauiDataStoreSqlite.Core.Entities.Task> DeleteTaskAsync(MauiDataStoreSqlite.Core.Entities.Task task, CancellationToken cancellationToken)
    {
        return await DeleteAsync(task, cancellationToken);
    }

    public async ValueTask<MauiDataStoreSqlite.Core.Entities.Task> GetByIdTaskAsync(string id, CancellationToken cancellationToken)
    {
        return await GetByIdAsync<MauiDataStoreSqlite.Core.Entities.Task>(id, cancellationToken);
    }
}

