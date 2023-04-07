namespace AbstractFactory;

/// <summary>
/// Команда к базе данных Oracle.
/// </summary>
public class OracleCommand : ICommand
{
    /// <summary>
    /// Текст команды.
    /// </summary>
    private readonly string _commandText;

    /// <summary>
    /// Создать экземпляр <see cref="OracleCommand"/>
    /// </summary>
    /// <param name="commandText">Текст команды.</param>
    public OracleCommand(string commandText)
    {
        _commandText = commandText;
    }

    /// <summary>
    /// Выполнить команду.
    /// </summary>
    public void Execute()
    {
        Console.WriteLine($"Oracle command '{_commandText}' has executed");
    }
}
