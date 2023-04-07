namespace AbstractFactory;

/// <summary>
/// Фабрика объектов базы данных MySql.
/// </summary>
public class MySqlFactory : IDatabaseFactory
{
    /// <summary>
    /// Создать команду MySql.
    /// </summary>
    public ICommand CreateCommand(string commandText)
    {
        return new MySqlCommand(commandText);
    }

    /// <summary>
    /// Создать соединение с БД MySql.
    /// </summary>
    public IConnection CreateConnection(string connectionString)
    {
        return new MySqlConnection(connectionString);
    }
}
