namespace AbstractFactory;

/// <summary>
/// Фабрика объектов базы данных Oracle.
/// </summary>
public class OracleFactory : IDatabaseFactory
{
    /// <summary>
    /// Создать команду Oracle.
    /// </summary>
    public ICommand CreateCommand(string commandText)
    {
        return new OracleCommand(commandText);
    }

    /// <summary>
    /// Создать соединение с БД Oracle.
    /// </summary>
    public IConnection CreateConnection(string connectionString)
    {
        return new OracleConnection(connectionString);
    }
}
