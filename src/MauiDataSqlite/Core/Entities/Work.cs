namespace MauiDataSqlite.Core.Entities;

public class Work: BaseEntity, IAggregateRoot
{
	public string Name { get; set; }
	public bool IsToday { get; set; }
	public bool IsCompleted { get; set; }
	public bool IsImportant { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public Guid CategoryId { get; set; }
	public Category Category { get; set; }
}

