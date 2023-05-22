using System.Collections.Concurrent;

namespace Singleton;

/// <summary>
/// Класс кэша, объект которого должен существовать в приложении в единственном экземпларе.
/// </summary>
public class Cache
{
    /// <summary>
    /// Идентификатор объекта класса.
    /// </summary>
    private readonly Guid _id = Guid.NewGuid();

    /// <summary>
    /// Данные кэша.
    /// </summary>
    private readonly ConcurrentDictionary<int, string> _data = new ConcurrentDictionary<int, string>();

    /// <summary>
    /// Хранит единственный экземпляр класса.
    /// </summary>
    private static Cache? _instance;

    /// <summary>
    /// Объект блокировки потоков для синхронизации.
    /// </summary>
    private static object _lockObject = new object();

    /// <summary>
    /// Создать новый экземпляр класса <see cref="Cache"/>.
    /// Уровень доступа "protected" для того, чтобы не было возможности в приложении напрямую вызвать создание экземпляра класса.
    /// </summary>
    protected Cache() { }

    /// <summary>
    /// Сохранить данные в кэш.
    /// </summary>
    public void Save(int key, string value)
    {
        Console.WriteLine($"Value '{value}' for key '{key}' added to cache with id '{_id}'");
        _data.AddOrUpdate(key, value, (k, v) => value);
    }

    /// <summary>
    /// Получить данные из кэша.
    /// </summary>
    public string? Get(int key)
    {
        if (_data.TryGetValue(key, out var value))
        {
            Console.WriteLine($"Value '{value}' for key '{key}' was retrieved from cache with id '{_id}'");
            return value;
        }

        return null;
    }

    /// <summary>
    /// Метод доступа к экземпляру кэша.
    /// </summary>
    public static Cache Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lockObject)
                {
                    // Повторная проверка на null, так как с момента первой проверки до постановки блокировки, могла успеть выполниться операция инициализации инстанса.
                    // Такой подход называют double check.
                    if (_instance is null)
                        _instance = new Cache();
                }
            }

            return _instance;
        }
    }
}
