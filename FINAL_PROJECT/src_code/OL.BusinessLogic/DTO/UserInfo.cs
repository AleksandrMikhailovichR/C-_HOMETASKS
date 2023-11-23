namespace OL.BusinessLogic;

public readonly record struct UserInfo(
    long Id,
    string FirstName,
    string LastName,
    short Age,
    string Preferences,
    DateTime RegistrationDate
);