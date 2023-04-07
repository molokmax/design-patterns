namespace AbstractFactory;

/// <summary>
/// Соединение с базой данных MySql.
/// </summary>
public class MySqlConnection : IConnection
{
    /// <summary>
    /// Строка подключения.
    /// </summary>
    private readonly string _connectionString;

    /// <summary>
    /// Создать экземпляр <see cref="MySqlConnection"/>.
    /// </summary>
    /// <param name="connectionString">Строка подключения.</param>
    public MySqlConnection(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Открыть соединение.
    /// </summary>
    public void Close()
    {
        Console.WriteLine($"MySql connection with '{_connectionString}' has closed");
    }

    /// <summary>
    /// Закрыть соединение.
    /// </summary>
    public void Open()
    {
        Console.WriteLine($"MySql connection with '{_connectionString}' has opened");
    }
}
