namespace MauiDataStoreSqlite.Core.Entities;

public class Task: BaseEntity
{
	public string Name { get; set; }
	//public Group Group { get; set; }
	public bool IsToday { get; set; }
	public bool IsCompleted { get; set; }
	public bool IsImportant { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
}

