namespace MauiDataSqlite.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly ILogger<Category> _logger;
    private readonly IRepository<Category> _repository;

    public CategoryService(ILogger<Category> logger, IRepository<Category> repository)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async ValueTask<Category> CreateCategoryAsync(Category category, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Create category name {category.Name}");
        return await _repository.CreateAsync(category, cancellationToken);
    }

    public async ValueTask<Category> UpdateCategoryAsync(Category category, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Update category id {category.Id}");
        return await _repository.UpdateAsync(category, cancellationToken);
    }

    public async ValueTask<Category> DeleteCategoryAsync(Category category, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Delete category id {category.Id}");
        return await _repository.DeleteAsync(category, cancellationToken);
    }

    public async ValueTask<Category> GetCategoryByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Get category id {id}");
        return await _repository.GetByIdAsync(id, cancellationToken);
    }

    public async ValueTask<IEnumerable<Category>> GetAllCategoryAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Lists categories");
        return await _repository.ListAsync(cancellationToken);
    }

    public async ValueTask<IEnumerable<Category>> GetAllByStateCategoryAsyc(bool state, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Lists category by state {state}");
        CategorySpecification specification = new(state);
        return await _repository.ListAsync(specification, cancellationToken);
    }

    public async ValueTask<Category> GetCategoryByNameAsync(string nameCategory, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Find category by name {nameCategory}");
        CategorySpecification specification = new(nameCategory);
        return await _repository.FirstOrDefaultAsync(specification, cancellationToken);
    }
}