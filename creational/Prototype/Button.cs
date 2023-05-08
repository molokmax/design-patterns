namespace Prototype;

/// <summary>
/// Компонтент кнопки, имеющий возможность копирования.
/// </summary>
public class Button : IComponent
{
    /// <summary>
    /// Идентификатор кнопки.
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// Текст на кнопке.
    /// </summary>
    public required string Text { get; set; }

    /// <inheritdoc />
    public IComponent Clone()
    {
        return new Button { Id = Id, Text = Text };
    }

    /// <inheritdoc />
    public string GetInfo()
    {
        return $"Button {Id} with text '{Text}'";
    }
}
