namespace Builder;

/// <summary>
/// Директор сборки команды. Можно передавать разные <see cref="ISelectCommandBuilder"/>, при этом набор шагов для сборки не изменяется.
/// </summary>
public class SelectCommandDirector
{
    private readonly ISelectCommandBuilder _builder;
    public SelectCommandDirector(ISelectCommandBuilder builder)
    {
        _builder = builder;
    }

    /// <summary>
    /// Выполнить шаги для сборки команды.
    /// </summary>
    public ISelectCommand Construct(string[] fields, string table, string criteria)
    {
        _builder.Select(fields);
        _builder.From(table);
        _builder.Where(criteria);

        return _builder.Build();
    }
}
