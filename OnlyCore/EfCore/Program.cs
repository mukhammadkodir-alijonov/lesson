using EfCore.DbContexts;
using EfCore.Models;

class Program
{
    public static void Main(string[] args)
    {
        AppDbContext appDbContext = new AppDbContext();
        var user = appDbContext.Users.Find((long)1);
        if(user is not null) appDbContext.Users.Remove(user);
        appDbContext.SaveChanges();
        
    }
}
