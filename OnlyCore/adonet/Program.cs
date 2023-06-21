using adonet.Interface.Repositories;
using adonet.Models;
using adonet.Repositories571632;
using Npgsql;

namespace adonet;

public class Program
{
    public static async Task Main(string[] args)
    {
        User user = new User()
        {
            FullName = "Sattarov Diyirbek",
            Email = "Diyirbek@gmail.com",
            PhoneNUmber = "+998945044556",
            Adress = "Namangan vil"
        };
        IUserRepository repository = new UserRepository();
        var result = await repository.UpdateAsync(4,user);
        Console.WriteLine(result);
    }
}