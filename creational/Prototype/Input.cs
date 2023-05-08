namespace Prototype;

/// <summary>
/// Компонент поля ввода, имеющий возможность копирования.
/// </summary>
public class Input : IComponent
{
    /// <summary>
    /// Идентификатор поля ввода.
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// Значение поля ввода.
    /// </summary>
    public string? Value { get; set; }

    /// <inheritdoc />
    public IComponent Clone()
    {
        return new Input { Id = Id, Value = Value };
    }

    /// <inheritdoc />
    public string GetInfo()
    {
        return $"Input {Id} with value '{Value}'";
    }
}
