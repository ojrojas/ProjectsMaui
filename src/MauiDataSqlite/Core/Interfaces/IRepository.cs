namespace MauiDataSqlite.Core.Interfaces;

public interface IRepository<T>
{
    ValueTask<int> CountAsync(CancellationToken cancellationToken);
    ValueTask<T> CreateAsync(T entity, CancellationToken cancellationToken);
    ValueTask<T> DeleteAsync(T entity, CancellationToken cancellationToken);
    ValueTask<T> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken);
    ValueTask<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    ValueTask<IEnumerable<T>> ListAsync(CancellationToken cancellationToken);
    ValueTask<IEnumerable<T>> ListAsync(ISpecification<T> spec, CancellationToken cancellationToken);
    ValueTask<T> UpdateAsync(T entity, CancellationToken cancellationToken);
}