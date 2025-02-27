using SocioVerseModels.User;

namespace SocioVerseRepositories.User
{
    public interface IUserRepository
    {
        public IEnumerable<UserModel> GetAllUser();
        public UserModel? GetUserbyUsername(string username);
        public IEnumerable<UserModel> GetUserByKeyword(string keyword);
        public UserModel GetUserById(long userId); 
        public UserModel CreateUser(UserModel user);
        public UserModel UpdateUser(UserModel user);
        public bool DeactiveUser(long userId);
        public bool DeleteUser(long userId);
    }
}