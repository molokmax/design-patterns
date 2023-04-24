using System.Data;

namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 4)
        {
            Console.WriteLine("Run format: Builder.exe {Sql|Mongo} Select From Filter");
            Console.WriteLine("Example: Builder.exe Sql Id,Name,Description Catalog Name=Test");
            return;
        }

        var dbType = args[0].ToLower();
        var selectString = args[1];
        var fields = selectString.Split(',');
        var fromString = args[2];
        var filterString = args[3];
        var builder = CreateBuilder(dbType);
        var director = new SelectCommandDirector(builder);
        var command = director.Construct(fields, fromString, filterString);
        command.Execute();
    }

    private static ISelectCommandBuilder CreateBuilder(string dbType)
    {
        switch (dbType.ToLower())
        {
            case "sql":
                return new SelectSqlCommandBuilder();
            case "mongo":
                return new SelectMongoCommandBuilder();
            default:
                throw new NotSupportedException($"Database type '{dbType}' is not supported");
        }
    }
}
