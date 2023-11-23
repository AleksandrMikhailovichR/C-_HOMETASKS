
public class PasswordGenHelper
{
    public static bool IsValidPassword(string pwrd)
    {
        return pwrd.Any(char.IsDigit) && pwrd.Any(char.IsUpper) && pwrd.Any(c => "@$!_*^-+".Contains(c));
    }
    
    public static string PasswordGeneration()
    {
        string symbols = "abcdefghijk012345lmnopqrstuvvwxyz@$!_*-+ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        bool flag = false;
        string password = "";
        Random random = new();
        
        while (!flag)
        {
            password = "";
            for (int i = 0; i < 12; i++)
            {
                password += symbols[random.Next(0, symbols.Length)];
            }
            
            if (IsValidPassword(password))
            {
                flag = true;
            }
        }
        
        return password;
    }
}

