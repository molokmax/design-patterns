namespace AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Run format: AbstractFactory.exe {MySql|Oracle} ConnectionString CommandText");
            return;
        }

        var connectionType = args[0].ToLower();
        var connectionString = args[1];
        var commandText = args[2];
        IDatabaseFactory factory;
        switch (connectionType)
        {
            case "mysql":
                factory = new MySqlFactory();
                break;
            case "oracle":
                factory = new OracleFactory();
                break;
            default:
                throw new NotSupportedException($"Connection type '{connectionType}' is not supported");
        }

        var connection = factory.CreateConnection(connectionString);
        var command = factory.CreateCommand(commandText);
        connection.Open();
        command.Execute();
        connection.Close();
    }
}