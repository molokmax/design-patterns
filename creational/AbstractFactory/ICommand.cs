namespace AbstractFactory;

/// <summary>
/// Интерфейс команды к базе данных.
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Выполнить команду.
    /// </summary>
    void Execute();
}
