using System.ComponentModel.DataAnnotations;

public class User
{
    public long UserId { get; set; }
    [Required]
    [StringLength(25, MinimumLength = 3)]
    public string UserFName { get; set; } = string.Empty;
    [Required]
    [StringLength(40, MinimumLength = 4)]
    public string UserLName { get; set; } = string.Empty;
    [Required]
    [Range(14, 110)]
    public short UserAge {get; set;}
    public string UserPreferences {get; set;} = string.Empty;
    public DateTime RegistrationDate {get; set;}

}
