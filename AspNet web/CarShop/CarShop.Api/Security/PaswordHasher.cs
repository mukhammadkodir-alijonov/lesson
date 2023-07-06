
namespace CarShop.Api.Security
{
    public class PaswordHasher
    {
        public static (string PasswordHash, string Salt) Hash(string password)
        {
            string salt = Guid.NewGuid().ToString();
            string paswordHash = BCrypt.Net.BCrypt.HashPassword(password + salt);
            return (PasswordHash: paswordHash, Salt: salt);
        }
        /*public static bool Verify(string passowrd, string salt, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(passowrd + salt, passwordHash);
        }
        public static string GenerateSalt()
        {
            return Guid.NewGuid().ToString();
        }*/
    }
}
