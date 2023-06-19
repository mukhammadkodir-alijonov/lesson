using Npgsql;

namespace adonet;

public class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Host=localhost; Port=5432; Database=adonet-db; User Id=postgres; Password=alijonovm;";

        string query = "SELECT * FROM users;";

        NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
        npgsqlConnection.Open();

        NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

        var reader = npgsqlCommand.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader.GetString(1));
        }
    }
}