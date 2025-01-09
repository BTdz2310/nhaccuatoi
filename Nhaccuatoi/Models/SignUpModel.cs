using System.ComponentModel.DataAnnotations;

namespace Nhaccuatoi.Models;

public class SignUpModel
{
    [Required]
    public string Username { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}