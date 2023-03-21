namespace MauiDataSqlite.Core.Services;

public class WorkService : IWorkService
{
    private readonly ILogger<WorkService> _logger;
    private readonly IRepository<Work> _repository;

    public WorkService(ILogger<WorkService> logger, IRepository<Work> repository)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async ValueTask<Work> CreateWorkAsync(Work Work, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Create Work name {Work.Name}");
        return await _repository.CreateAsync(Work, cancellationToken);
    }

    public async ValueTask<Work> UpdateWorkAsync(Work Work, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Update Work id {Work.Id}");
        return await _repository.UpdateAsync(Work, cancellationToken);
    }

    public async ValueTask<Work> DeleteWorkAsync(Work Work, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Delete Work id {Work.Id}");
        return await _repository.DeleteAsync(Work, cancellationToken);
    }

    public async ValueTask<Work> GetWorkByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Get Work id {id}");
        return await _repository.GetByIdAsync(id, cancellationToken);
    }

    public async ValueTask<IEnumerable<Work>> GetAllWorkAsync(Work Work, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Lists categories {Work.Name}");
        return await _repository.ListAsync(cancellationToken);
    }

    public async ValueTask<IEnumerable<Work>> GetAllWorkByStateAsyc(bool state, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Lists Work by state {state}");
        WorkSpecification specification = new(state);
        return await _repository.ListAsync(specification, cancellationToken);
    }

    public async ValueTask<IEnumerable<Work>> GetAllWorkByCategoryIdAsyc(Guid categoryId, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Lists Work by category Id {categoryId}");
        WorkSpecification specification = new(categoryId);
        return await _repository.ListAsync(specification, cancellationToken);
    }
}

