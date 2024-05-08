using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppl.Models;

namespace WebAppl.Pages;

public class SignInModel : PageModel
{

    public string PageTitle { get; set; } = "Sign in";

    [BindProperty]
    public SignInFormModel Form { get; set; } = new SignInFormModel();



    public void OnGet()
    {
    }


    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("/index");
    }
}
