using foodshop.Modal;

namespace foodshop.Service.Userss
{
    public interface IUsersService
    {
        List<Users> GetUser();
        Boolean AddUsers(Users users);
        Boolean UpdateUsers(Users users);
        Boolean DeleteUsers(int id);
        //Boolean DeleteUsers(int id);
    }
}
