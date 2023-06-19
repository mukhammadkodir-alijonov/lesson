using Npgsql;

namespace adonet;

public class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Host=localhost; Port=5432; Database=adonet-db; User Id=postgres; Password=alijonovm;";

        string query = "INSERT INTO public.users(\r\n\tfull_name, email, phone_number, adress)" + 
            "VALUES \r\n\t('Malikov Sardor', 'Malikov@gmail.com', '+998945041234', 'Jizzah vil');";

        NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
        npgsqlConnection.Open();

        NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsqlConnection);

        var result = npgsqlCommand.ExecuteNonQuery();
        Console.WriteLine(result);
    }
}