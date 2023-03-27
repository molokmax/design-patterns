namespace FactoryMethod;

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
    /// Выполнить команду.
    /// </summary>
    public void ExecuteCommand()
    {
        Console.WriteLine($"Command has executed on server Oracle with connection string '{_connectionString}'");
    }
}
