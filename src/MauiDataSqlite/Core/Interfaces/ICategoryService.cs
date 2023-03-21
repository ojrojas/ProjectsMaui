namespace MauiDataSqlite.Core.Interfaces;

public interface ICategoryService
{
    ValueTask<Category> CreateCategoryAsync(Category category, CancellationToken cancellationToken);
    ValueTask<Category> DeleteCategoryAsync(Category category, CancellationToken cancellationToken);
    ValueTask<IEnumerable<Category>> GetAllByStateCategoryAsyc(bool state, CancellationToken cancellationToken);
    ValueTask<IEnumerable<Category>> GetAllCategoryAsync(CancellationToken cancellationToken);
    ValueTask<Category> GetCategoryByIdAsync(Guid id, CancellationToken cancellationToken);
    ValueTask<Category> UpdateCategoryAsync(Category category, CancellationToken cancellationToken);
    ValueTask<Category> GetCategoryByNameAsync(string nameCategory, CancellationToken cancellationToken);
}