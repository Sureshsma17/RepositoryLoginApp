using LoginApp.Models;
namespace LoginApp.Repositories
{
    public interface ILoginRepository
    {
        LoginA ValidateUser(string username, string password);
    }
}
