namespace MauiDataStoreSqlite.Core.Interfaces
{
    public interface ITaskService
    {
        ValueTask<Entities.Task> CreateTaskAsync(Entities.Task task, CancellationToken cancellationToken);
        ValueTask<Entities.Task> DeleteTaskAsync(Entities.Task task, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Entities.Task>> GetAllTaskAsync(CancellationToken cancellationToken);
        ValueTask<Entities.Task> GetByIdTaskAsync(string id, CancellationToken cancellationToken);
        ValueTask<Entities.Task> UpdateTaskAsync(Entities.Task task, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Core.Entities.Task>> GetAllTaskByGroupIdAsync(string idGroup, CancellationToken cancellationToken);
    }
}