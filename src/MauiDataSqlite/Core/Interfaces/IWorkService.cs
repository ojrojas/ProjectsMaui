namespace MauiDataSqlite.Core.Interfaces;

public interface IWorkService
{
    ValueTask<Work> CreateWorkAsync(Work Work, CancellationToken cancellationToken);
    ValueTask<Work> DeleteWorkAsync(Work Work, CancellationToken cancellationToken);
    ValueTask<IEnumerable<Work>> GetAllWorkAsync(Work Work, CancellationToken cancellationToken);
    ValueTask<IEnumerable<Work>> GetAllWorkByCategoryIdAsyc(Guid categoryId, CancellationToken cancellationToken);
    ValueTask<IEnumerable<Work>> GetAllWorkByStateAsyc(bool state, CancellationToken cancellationToken);
    ValueTask<Work> GetWorkByIdAsync(Guid id, CancellationToken cancellationToken);
    ValueTask<Work> UpdateWorkAsync(Work Work, CancellationToken cancellationToken);
}