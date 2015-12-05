using IdleTalks.Repository.DTO;

namespace IdleTalks.Repository
{
    public interface IUserRepository
    {
        long AddUser(User user);

        User GetUser(long id);

        void ChangePassword(long userId, string newPassword);

        bool CheckPassword(long userId, string password);
    }
}