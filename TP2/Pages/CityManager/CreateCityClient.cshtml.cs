// Exercício: 4
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.CityManager;

public class CreateCityClientModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? Message { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome da cidade precisa ter no mínimo 3 caracteres.")]
        [Display(Name = "Nome da cidade")]
        public string CityName { get; set; } = "";
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Message = $"Cidade {Input.CityName} cadastrada com sucesso!";
        return Page();
    }
}
