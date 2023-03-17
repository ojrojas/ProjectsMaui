namespace MauiDataStoreSqlite.Core.Entities;

public class BaseEntity
{
    public string Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public bool State { get; set; }
}

