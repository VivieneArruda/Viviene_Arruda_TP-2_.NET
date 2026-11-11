// Exercício: 6
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2.Models;

namespace TP2.Pages.CountryManager;

public class CreateCountryIsoModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();

    public Country? NewCountry { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "Informe o nome do país.")]
        [Display(Name = "Nome do país")]
        public string CountryName { get; set; } = "";

        [Required(ErrorMessage = "Informe o código do país.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país deve ter exatamente 2 letras.")]
        [Display(Name = "Código do país")]
        public string CountryCode { get; set; } = "";
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

        NewCountry = new Country
        {
            CountryName = Input.CountryName,
            CountryCode = Input.CountryCode.ToUpper()
        };
        return Page();
    }
}
