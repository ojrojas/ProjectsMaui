namespace MauiDataSqlite.Core.Specifications;

public class CategorySpecification :Specification<Category>
{
	public CategorySpecification(bool state)
	{
		Query.Where(x => x.State.Equals(state));
	}

	public CategorySpecification(string nameCategory)
	{
		Query.Where(x => x.Name.Equals(nameCategory));
	}
}

