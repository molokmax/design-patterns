namespace FactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Run format: FactoryMethod.exe {MySql|Oracle} ConnectionString");
            return;
        }

        var connectionType = args[0].ToLower();
        var connectionString = args[1];
        ConnectionFactory factory;
        switch (connectionType)
        {
            case "mysql":
                factory = new MySqlConnectionFactory(connectionString);
                break;
            case "oracle":
                factory = new OracleConnectionFactory(connectionString);
                break;
            default:
                throw new NotSupportedException($"Connection type '{connectionType}' is not supported");
        }

        var connection = factory.CreateConnection();
        connection.ExecuteCommand();
    }
}
