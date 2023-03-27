namespace FactoryMethod;

/// <summary>
/// Фабрика соединений с базой данных MySql.
/// </summary>
public class MySqlConnectionFactory : ConnectionFactory
{
    /// <summary>
    /// Строка подключения.
    /// </summary>
    private readonly string _connectionString;

    /// <summary>
    /// Создать экземпляр <see cref="MySqlConnectionFactory"/>
    /// </summary>
    /// <param name="connectionString">Строка подключения.</param>
    public MySqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Создать соединение с базой данных MySql.
    /// </summary>
    /// <returns>Соединение.</returns>
    public override IConnection CreateConnection()
    {
        return new MySqlConnection(_connectionString);
    }
}
