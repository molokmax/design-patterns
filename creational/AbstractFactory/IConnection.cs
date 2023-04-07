namespace AbstractFactory;

/// <summary>
/// Интерфейс соединения с базой данных.
/// </summary>
public interface IConnection
{
    /// <summary>
    /// Закрыть соединение.
    /// </summary>
    void Close();

    /// <summary>
    /// Открыть соединение.
    /// </summary>
    void Open();
}
