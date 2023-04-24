namespace Builder;

/// <summary>
/// Построитель команды на выборку данных из Mongo.
/// </summary>
public class SelectMongoCommandBuilder : ISelectCommandBuilder
{
    /// <summary>
    /// Конфигурация списка полей для выборки.
    /// </summary>
    private string[] _select = Array.Empty<string>();

    /// <summary>
    /// Конфигурация источника выборки.
    /// </summary>
    private string _from = string.Empty;

    /// <summary>
    /// Конфигурация фильтра.
    /// </summary>
    private string _where = string.Empty;

    /// <summary>
    /// Сконфигурировтаь какие поля должны быть в выборке.
    /// </summary>
    public void Select(string[] fields)
    {
        _select = fields;
    }

    /// <summary>
    /// Сконфигурировать из какой коллекции нужно сделать выборку.
    /// </summary>
    public void From(string collection)
    {
        _from = collection;
    }

    /// <summary>
    /// Сконфигурировать фильтр выборки.
    /// </summary>
    public void Where(string criteria)
    {
        _where = criteria;
    }

    /// <summary>
    /// Выполнить сборку команды.
    /// </summary>
    public ISelectCommand Build()
    {
        return new SelectMongoCommand(_select, _from, _where);
    }
}
