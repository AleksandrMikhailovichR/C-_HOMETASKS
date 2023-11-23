namespace OL.BusinessLogic;

public sealed class UserService : IUserService
{
    private readonly List<User> _users;

    private long _id = 0;
    
    public UserService() 
    {
        _users = new();
    }

 
    public UserInfo CreateUser(UserInfo userInfo)
    {
        User newUser = new()
        {
            UserId = _id++,
            UserFName = userInfo.FirstName,
            UserLName = userInfo.LastName,
            UserAge = userInfo.Age,
            UserPreferences = userInfo.Preferences,
            RegistrationDate = userInfo.RegistrationDate
        };

        _users.Add(newUser);

        return userInfo with {Id = newUser.UserId};

    }

        public bool RemoveUser(string firstName, string lastName)
    {
        if (firstName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(firstName));

        if (lastName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(lastName));

        int userIndex = _users.FindIndex(c => c.UserFName.Equals(firstName) && c.UserLName.Equals(lastName));
        if (userIndex < 0)
            return false;

        _users.RemoveAt(userIndex);

        return true;
    }

        public UserInfo GetUser(string firstName, string lastName)
    {
        if (firstName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(firstName));

        if (lastName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(lastName));

        User? user = _users.Find(c => c.UserFName.Equals(firstName) && c.UserLName.Equals(lastName))
            ?? throw new NotFoundException();
        return user.ToClientInfo();
    }
}