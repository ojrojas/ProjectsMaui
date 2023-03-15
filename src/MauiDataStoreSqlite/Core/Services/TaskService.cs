namespace MauiDataStoreSqlite.Core.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;
    private readonly ILogger<TaskService> _logger;

    public TaskService(ITaskRepository repository, ILogger<TaskService> logger)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async ValueTask<IEnumerable<Core.Entities.Task>> GetAllTaskAsync(CancellationToken cancellationToken)
    {
        return await _repository.GetAllTaskAsync(cancellationToken);
    }

    public async ValueTask<Core.Entities.Task> CreateTaskAsync(Core.Entities.Task task, CancellationToken cancellationToken)
    {
        return await _repository.CreateTaskAsync(task, cancellationToken);
    }

    public async ValueTask<Core.Entities.Task> UpdateTaskAsync(Core.Entities.Task task, CancellationToken cancellationToken)
    {
        return await _repository.UpdateTaskAsync(task, cancellationToken);
    }

    public async ValueTask<Core.Entities.Task> DeleteTaskAsync(Core.Entities.Task task, CancellationToken cancellationToken)
    {
        return await _repository.DeleteTaskAsync(task, cancellationToken);
    }

    public async ValueTask<Core.Entities.Task> GetByIdTaskAsync(string id, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdTaskAsync(id, cancellationToken);
    }
}

