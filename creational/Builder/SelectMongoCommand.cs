namespace Builder;

/// <summary>
/// Команда выборки данных из Mongo.
/// </summary>
internal class SelectMongoCommand : ISelectCommand
{
    /// <summary>
    /// Текст запроса.
    /// </summary>
    private readonly string _query;

    /// <summary>
    /// Создать новый экземпляр <see cref="SelectMongoCommand"/>.
    /// </summary>
    public SelectMongoCommand(string[] fields, string collection, string criteria)
    {
        _query = $"Find {string.Join(',', fields)} From {collection} Where {criteria}";
    }

    /// <summary>
    /// Выполнить выборку данных из Mongo.
    /// </summary>
    public ICollection<string> Execute()
    {
        Console.WriteLine("MongoDb Command: {0}", _query);

        return Array.Empty<string>();
    }
}
