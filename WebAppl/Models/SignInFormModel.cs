namespace WebAppl.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

public class SignInFormModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "*********")]
    [Required(ErrorMessage = "Invalid Password")]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; } = false;
}
