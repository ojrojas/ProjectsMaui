namespace MauiDataStoreSqlite.Core.Interfaces
{
    public interface IGroupService
    {
        ValueTask<Group> CreateGroupAsync(Group Group, CancellationToken cancellationToken);
        ValueTask<Group> DeleteGroupAsync(Group Group, CancellationToken cancellationToken);
        ValueTask<IEnumerable<Group>> GetAllGroupsAsync(CancellationToken cancellationToken);
        ValueTask<Group> GetByIdGroupAsync(string id, CancellationToken cancellationToken);
        ValueTask<Group> UpdateGroupAsync(Group Group, CancellationToken cancellationToken);
    }
}