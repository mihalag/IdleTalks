using IdleTalks.Repository.DTO;

namespace IdleTalks.Repository
{
    public interface IUserRepository
    {
        long AddUser(User user);

        User GetUser(long id);
    }
}