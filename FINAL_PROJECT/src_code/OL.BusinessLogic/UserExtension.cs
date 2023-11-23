namespace OL.BusinessLogic;

public static class UserExtension
{
    public static UserInfo ToUserInfo(this User user)
    {
        return new(
            user.UserId,
            user.UserFName,
            user.UserLName,
            user.UserAge, 
            user.UserPreferences,
            user.RegistrationDate
        );    
    }
}
