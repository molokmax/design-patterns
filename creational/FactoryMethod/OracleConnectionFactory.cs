namespace FactoryMethod;

/// <summary>
/// Фабрика соединений с базой данных Oracle.
/// </summary>
public class OracleConnectionFactory : ConnectionFactory
{
    /// <summary>
    /// Строка подключения.
    /// </summary>
    private readonly string _connectionString;

    /// <summary>
    /// Создать экземпляр <see cref="OracleConnectionFactory"/>
    /// </summary>
    /// <param name="connectionString">Строка подключения.</param>
    public OracleConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Создать соединение с базой данных Oracle.
    /// </summary>
    /// <returns>Соединение.</returns>
    public override IConnection CreateConnection()
    {
        return new OracleConnection(_connectionString);
    }
}
