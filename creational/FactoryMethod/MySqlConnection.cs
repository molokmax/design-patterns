namespace FactoryMethod;

/// <summary>
/// Соединение с базой данных MySQL.
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
    /// Выполнить команду.
    /// </summary>
    public void ExecuteCommand()
    {
        Console.WriteLine($"Command has executed on server MySql with connection string '{_connectionString}'");
    }
}
