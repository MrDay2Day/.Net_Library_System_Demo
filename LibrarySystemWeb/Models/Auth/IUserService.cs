namespace LibrarySystemWeb.Models.Auth
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
    }
}
