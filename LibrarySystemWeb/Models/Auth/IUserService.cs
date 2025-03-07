namespace LibrarySystemWeb.Models.Auth
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string email, string password);
    }
}
