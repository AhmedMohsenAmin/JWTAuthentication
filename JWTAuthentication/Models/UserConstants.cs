namespace JWTAuthentication.Models
{
    public class UserConstants
    {
        public static List<UserModel> users = new()
        {
            new UserModel()
            {
                UserName = "Mohsen",
                Password = "123456",
                Role = "Admin"
            },
             new UserModel()
            {
                UserName = "Megz",
                Password = "123456",
                Role = "User"
            }
        };
    }
}
