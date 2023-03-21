namespace MauiDataSqlite.Core.Specifications;

public class WorkSpecification : Specification<Work>
{
	public WorkSpecification(Guid categoryId)
	{
		Query.Where(x => x.CategoryId.Equals(categoryId));
	}

	public WorkSpecification(bool state)
	{
		Query.Where(x => x.State.Equals(state));
	}
}

