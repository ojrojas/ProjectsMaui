namespace MauiDataStoreSqlite.Core.Repositories;

public static class GroupSeed
{
    public static IEnumerable<Group> Groups = new List<Group>
    {
        new Group
        {
            Id = Guid.NewGuid().ToString(),
            Name = "AllTodo",
            CreatedOn= DateTime.UtcNow,
            State = true
        },
        new Group
        {
            Id = Guid.NewGuid().ToString(),
            Name = "MyTodo",
            CreatedOn= DateTime.UtcNow,
            State = true
        }
    };
}

