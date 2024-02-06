using LoginBackend.Models;

namespace LoginBackend.Services
{
public class UserManager
{
    private static List<UserModel> users = new List<UserModel>
    {
        new UserModel { UserName = "Asutosh", Password = "1234" },
        new UserModel { UserName = "Saurabh", Password = "1234"},
        new UserModel { UserName = "Rishabh", Password = "1234"},
        new UserModel { UserName = "Vaibhav", Password = "1234"},
        new UserModel { UserName = "Aditya", Password = "1234"},
        new UserModel { UserName = "Asutosh", Password = "5678"},
        new UserModel { UserName = "Saurabh", Password = "5678"},
        new UserModel { UserName = "Rishabh", Password = "5678"},
        new UserModel { UserName = "Vaibhav", Password = "5678"},
        new UserModel { UserName = "Aditya", Password = "5678"}
    };

    public bool ValidateUser(UserModel user)
    {
        return users.Any(u => u.UserName == user.UserName && u.Password == user.Password);
    }
}

}
