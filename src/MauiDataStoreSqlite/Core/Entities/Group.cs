namespace MauiDataStoreSqlite.Core.Entities;

[Table("Group")]
public class Group: BaseEntity
{
    [MaxLength(250), Unique]
    public string Name { get; set; }
}

