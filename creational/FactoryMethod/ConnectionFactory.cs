namespace FactoryMethod;

/// <summary>
/// Базовый класс фабрики соединений с базой данных.
/// </summary>
public abstract class ConnectionFactory
{
    /// <summary>
    /// Создать экземпляр соединения с базой данных.
    /// </summary>
    /// <returns>Соединение.</returns>
    public abstract IConnection CreateConnection();
}
