namespace MauiDataStoreSqlite.Core.Interfaces
{
    public interface IGroupRepository
    {
        ValueTask<Group> CreateGroupAsync(Group group, CancellationToken cancellationToken);
        ValueTask<Group> DeleteGroupAsync(Group group, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Group>> GetAllGroupAsync(CancellationToken cancellationToken);
        ValueTask<Group> GetByIdGroupAsync(string id, CancellationToken cancellationToken);
        ValueTask<Group> UpdateGroupAsync(Group group, CancellationToken cancellationToken);
    }
}