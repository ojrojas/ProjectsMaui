namespace MauiDataStoreSqlite.Core.Interfaces
{
    public interface ITaskRepository
    {
        ValueTask<Entities.Task> CreateTaskAsync(Entities.Task task, CancellationToken cancellationToken);
        ValueTask<Entities.Task> DeleteTaskAsync(Entities.Task task, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Entities.Task>> GetAllTaskAsync(CancellationToken cancellationToken);
        ValueTask<Entities.Task> GetByIdTaskAsync(string id, CancellationToken cancellationToken);
        ValueTask<Entities.Task> UpdateTaskAsync(Entities.Task task, CancellationToken cancellationToken);
    }
}