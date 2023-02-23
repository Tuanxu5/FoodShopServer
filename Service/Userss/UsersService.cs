using foodshop.Data;
using foodshop.Modal;

namespace foodshop.Service.Userss
{
    public class UsersService : IUsersService
    {
        public readonly UsersDbContext _usersDbContext;

        public UsersService(UsersDbContext usersDbContext)
        {
            _usersDbContext = usersDbContext;
        }
        public bool AddUsers(Users users)
        {
            _usersDbContext.Userss.Add(users);
            _usersDbContext.SaveChanges();
            return true;
        }

        public bool DeleteUsers(int id)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetUser()
        {
            return _usersDbContext.Userss.ToList();
        }

        public bool UpdateUsers(Users users)
        {
            throw new NotImplementedException();
        }
        
    }
}
