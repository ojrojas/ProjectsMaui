namespace MauiDataSqlite.Core.Entities;

public class Category : BaseEntity, IAggregateRoot
{
    public string Name { get; set; }
    public string Page { get; set; } = "/Categories/CategorySelected";
}

