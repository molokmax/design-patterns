namespace AbstractFactory;

/// <summary>
/// Команда к базе данных MySql.
/// </summary>
public class MySqlCommand : ICommand
{
    /// <summary>
    /// Текст команды.
    /// </summary>
    private readonly string _commandText;

    /// <summary>
    /// Создать экземпляр <see cref="MySqlCommand"/>
    /// </summary>
    /// <param name="commandText">Текст команды.</param>
    public MySqlCommand(string commandText)
    {
        _commandText = commandText;
    }

    /// <summary>
    /// Выполнить команду.
    /// </summary>
    public void Execute()
    {
        Console.WriteLine($"MySql command '{_commandText}' has executed");
    }
}
