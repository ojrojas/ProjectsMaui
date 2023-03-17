namespace MauiDataStoreSqlite.Core.Entities;

[Table("Task")]
public class Task: BaseEntity
{
    [MaxLength(250), Unique]
    public string Name { get; set; }
	public Guid GroupId { get; set; }
	public bool IsToday { get; set; }
	public bool IsCompleted { get; set; }
	public bool IsImportant { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
}

