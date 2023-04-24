namespace Builder;

/// <summary>
/// Интерфейс для сборки команды на выборку данных.
/// </summary>
public interface ISelectCommandBuilder
{
    /// <summary>
    /// Сконфигурировтаь какие поля должны быть в выборке.
    /// </summary>
    void Select(string[] fields);

    /// <summary>
    /// Сконфигурировать из какой таблицы или коллекции нужно сделать выборку.
    /// </summary>
    void From(string table);

    /// <summary>
    /// Сконфигурировать фильтр выборки.
    /// </summary>
    void Where(string criteria);

    /// <summary>
    /// Выполнить сборку команды.
    /// </summary>
    ISelectCommand Build();
}
