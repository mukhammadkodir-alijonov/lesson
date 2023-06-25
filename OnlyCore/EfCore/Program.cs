using EfCore.DbContexts;
using EfCore.Models;

class Program
{
    public static void Main(string[] args)
    {
        AppDbContext appDbContext = new AppDbContext();
        var user = appDbContext.Users.Find((long)1);
        Console.WriteLine(user.ToString());
        /*User user = new User()
        {
            Firstname = "Sardor",
            Lastname = "Malikov",
            PhoneNumber = "+9989920023423",
            Address = "Andijon vil, Toraqo'rg'on tumani"
        };

        AppDbContext dbContext = new AppDbContext();
        dbContext.Users.Add(user);
        dbContext.SaveChanges();*/
    }
}
