namespace MauiDataStoreSqlite.Core.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _repository;
    private readonly ILogger<GroupService> _logger;

    public GroupService(IGroupRepository repository, ILogger<GroupService> logger)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async ValueTask<IEnumerable<Group>> GetAllGroupsAsync(CancellationToken cancellationToken)
    {
        return await _repository.GetAllGroupAsync(cancellationToken);
    }

    public async ValueTask<Group> CreateGroupAsync(Group Group, CancellationToken cancellationToken)
    {
        return await _repository.CreateGroupAsync(Group, cancellationToken);
    }

    public async ValueTask<Group> UpdateGroupAsync(Group Group, CancellationToken cancellationToken)
    {
        return await _repository.UpdateGroupAsync(Group, cancellationToken);
    }

    public async ValueTask<Group> DeleteGroupAsync(Group Group, CancellationToken cancellationToken)
    {
        return await _repository.DeleteGroupAsync(Group, cancellationToken);
    }

    public async ValueTask<Group> GetByIdGroupAsync(string id, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdGroupAsync(id, cancellationToken);
    }
}

