using SocioVerseModels.User;

namespace SocioVerseRepositories.User
{
    public class UserRepository : IUserRepository
    {
        public UserModel CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool DeactiveUser(long userId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(long userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(long userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetUserByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public UserModel? GetUserbyUsername(string username)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}