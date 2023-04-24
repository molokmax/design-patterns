namespace Builder;

/// <summary>
/// Команда выборки данных из SQL.
/// </summary>
internal class SelectSqlCommand : ISelectCommand
{
    /// <summary>
    /// Текст запроса.
    /// </summary>
    private readonly string _query;

    /// <summary>
    /// Создать новый экземпляр <see cref="SelectSqlCommand"/>.
    /// </summary>
    public SelectSqlCommand(string[] fields, string collection, string criteria)
    {
        _query = $"SELECT {string.Join(',', fields)} FROM {collection} WHERE {criteria};";
    }

    /// <summary>
    /// Выполнить выборку данных из SQL.
    /// </summary>
    public ICollection<string> Execute()
    {
        Console.WriteLine("SQL Command: {0}", _query);

        return Array.Empty<string>();
    }
}
