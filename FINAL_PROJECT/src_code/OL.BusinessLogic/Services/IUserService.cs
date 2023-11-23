namespace OL.BusinessLogic;
public interface IUserService
{
    public UserInfo CreateUser(UserInfo userInfo);
    public UserInfo GetUser(string firstName, string lastName);
    public bool RemoveUser(string firstName, string lastName);
}
