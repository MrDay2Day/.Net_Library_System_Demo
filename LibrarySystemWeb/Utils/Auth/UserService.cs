using System.Security.Cryptography;
using System.Text;
using LibrarySystemWeb.Data;
using LibrarySystemWeb.Models;

namespace LibrarySystemWeb.Utils.Auth
{

    public class UserService : IUserService
    {
        private readonly LibrarySystemContext _db;

        public UserService(LibrarySystemContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task<User> ValidateUserAsync(string email, string password)
        {
            try
            {
                Console.WriteLine($"Validating user: {email}");

                // Hash the password
                using SHA256 sha = SHA256.Create();
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();

                foreach (var b in data)
                {
                    sBuilder.Append(b.ToString("x2"));
                }

                string hashedPassword = sBuilder.ToString();
                Console.WriteLine("Password hashed successfully");

                // Find the user
                var user = _db.Users.FirstOrDefault(u =>
                    u.Email == email && u.Password == hashedPassword);

                Console.WriteLine($"User lookup result: {(user != null ? "Found" : "Not found")}");

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in ValidateUserAsync: {ex.Message}");
                throw; // Rethrow to be caught by the caller
            }
        }
    }
}