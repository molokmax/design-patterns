namespace AbstractFactory;

/// <summary>
/// Фабрика объектов базы данных.
/// </summary>
public interface IDatabaseFactory
{
    /// <summary>
    /// Создать команду к базе данных.
    /// </summary>
    ICommand CreateCommand(string commandText);

    /// <summary>
    /// Создать соединение с базой данных.
    /// </summary>
    IConnection CreateConnection(string connectionString);
}
