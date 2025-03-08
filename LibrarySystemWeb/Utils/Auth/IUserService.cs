using LibrarySystemWeb.Models;

namespace LibrarySystemWeb.Utils.Auth
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string email, string password);
    }
}
