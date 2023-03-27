namespace FactoryMethod;

/// <summary>
/// Интерфейс соединения с базой данных.
/// </summary>
public interface IConnection
{
    /// <summary>
    /// Выполнить команду.
    /// </summary>
    void ExecuteCommand();
}
