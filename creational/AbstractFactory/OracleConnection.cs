namespace AbstractFactory;

/// <summary>
/// Соединение с базой данных Oracle.
/// </summary>
public class OracleConnection : IConnection
{
    /// <summary>
    /// Строка подключения.
    /// </summary>
    private readonly string _connectionString;

    /// <summary>
    /// Создать экземпляр <see cref="OracleConnection"/>.
    /// </summary>
    /// <param name="connectionString">Строка подключения.</param>
    public OracleConnection(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Открыть соединение.
    /// </summary>
    public void Close()
    {
        Console.WriteLine($"Oracle connection with '{_connectionString}' has closed");
    }

    /// <summary>
    /// Закрыть соединение.
    /// </summary>
    public void Open()
    {
        Console.WriteLine($"Oracle connection with '{_connectionString}' has opened");
    }
}
