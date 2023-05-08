namespace Prototype;

/// <summary>
/// Интерфейс прототипа, объявляющий возможность клонирования.
/// </summary>
public interface IComponent
{
    /// <summary>
    /// Склонировать существующий объект.
    /// </summary>
    IComponent Clone();

    /// <summary>
    /// Получить текстовое описание компонента.
    /// </summary>
    string GetInfo();
}
