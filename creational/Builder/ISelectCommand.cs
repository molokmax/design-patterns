namespace Builder;

/// <summary>
/// Интерфейс команды на выборку данных.
/// </summary>
public interface ISelectCommand
{
    /// <summary>
    /// Запусить выборку данных.
    /// </summary>
    /// <returns>Возвращает список строк для упрощения.</returns>
    ICollection<string> Execute();
}
