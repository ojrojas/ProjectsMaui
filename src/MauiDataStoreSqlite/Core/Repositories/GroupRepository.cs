namespace MauiDataStoreSqlite.Core.Repositories;

public class GroupRepository : Repository, IGroupRepository
{
    private readonly ILogger<GroupRepository> _logger;

    public GroupRepository(ILogger<GroupRepository> logger, string dpath) : base(logger, dpath)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async ValueTask<IEnumerable<Group>> GetAllGroupAsync(CancellationToken cancellationToken)
    {
        return await GetAllAsync<Group>(cancellationToken);
    }

    public async ValueTask<Group> CreateGroupAsync(Group group, CancellationToken cancellationToken)
    {
        return await CreateAsync(group, cancellationToken);
    }

    public async ValueTask<Group> UpdateGroupAsync(Group group, CancellationToken cancellationToken)
    {
        return await UpdateAsync<Group>(group, cancellationToken);
    }

    public async ValueTask<Group> DeleteGroupAsync(Group group, CancellationToken cancellationToken)
    {
        return await DeleteAsync(group, cancellationToken);
    }

    public async ValueTask<Group> GetByIdGroupAsync(string id, CancellationToken cancellationToken)
    {
        return await GetByIdAsync<Group>(id, cancellationToken);
    }
}

