namespace MauiDataStoreSqlite.Core.Repositories;

public abstract class Repository
{
    /// <summary>
    /// Logger application debug environment
    /// </summary>
    private readonly ILogger<Repository> _logger;
    /// <summary>
    /// _connection sqlite file 
    /// </summary>
    private readonly SQLiteAsyncConnection _connection;

    /// <summary>
    /// Constructor Base logger and dpath file sqlite
    /// </summary>
    /// <param name="logger">Logger Application</param>
    /// <param name="dpath">Location file sqlite</param>
    public Repository(ILogger<Repository> logger, string dpath)
    {
        _logger = logger;
        try
        {
            _connection = new SQLiteAsyncConnection(dpath);

           var result =  _connection.CreateTablesAsync<Group, Entities.Task>().Result;
            _logger.LogInformation($"Create tables {nameof(Entities.Task)}");

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
        }
    }

    /// <summary>
    /// Create async entity model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Entity model to insert async</param>
    /// <returns>Entity registered</returns>
    public async Task<T> CreateAsync<T>(T entity, CancellationToken cancellationToken) where T : new()
    {
        _logger.LogInformation($"Insert data entity ");
        cancellationToken.ThrowIfCancellationRequested();
        var isInserted = await _connection.InsertAsync(entity);
        if (isInserted is not default(int))
        {
            return entity;
        }

        return default;
    }

    /// <summary>
    /// Update async entity model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Entity updated</param>
    /// <returns>Entity updated new params</returns>
    public async Task<T> UpdateAsync<T>(T entity, CancellationToken cancellationToken) where T : new()
    {
        _logger.LogInformation($"Updated data entity ");
        cancellationToken.ThrowIfCancellationRequested();
        var isUpdated = await _connection.UpdateAsync(entity);
        if (isUpdated is not default(int))
        {
            return entity;
        }

        return default;
    }

    /// <summary>
    /// Delete async entity 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Entity to delete from table</param>
    /// <returns>Entity deleted</returns>
    public async Task<T> DeleteAsync<T>(T entity, CancellationToken cancellationToken) where T : new()
    {
        _logger.LogInformation($"Delete item data entity ");
        cancellationToken.ThrowIfCancellationRequested();
        var isDeleted = await _connection.DeleteAsync(entity);
        if (isDeleted is not default(int))
        {
            return entity;
        }

        return default;
    }

    /// <summary>
    /// Get by id async 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="id">id type guid id </param>
    /// <returns>Entity request by id</returns>
    public async Task<T> GetByIdAsync<T>(string id, CancellationToken cancellationToken) where T : new()
    {
        _logger.LogInformation($"Get item data entity by id {id} typeof {typeof(T)}");
        cancellationToken.ThrowIfCancellationRequested();
        var mapping = await _connection.GetMappingAsync<T>();
        return (T)await _connection.GetAsync(id, mapping);
    }

    /// <summary>
    /// Get all async records 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>List entities request</returns>
    public async Task<IEnumerable<T>> GetAllAsync<T>(CancellationToken cancellationToken) where T : new()
    {
        _logger.LogInformation($"Get all items data entity typeof {typeof(T)} ");
        cancellationToken.ThrowIfCancellationRequested();
        return await _connection.Table<T>().ToListAsync();
    }
}