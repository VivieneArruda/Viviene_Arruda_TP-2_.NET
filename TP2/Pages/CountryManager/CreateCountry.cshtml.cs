// Exercício: 5
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2.Models;

namespace TP2.Pages.CountryManager;

public class CreateCountryModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();

    public Country? NewCountry { get; set; }

    public class InputModel
    {
        [Display(Name = "Nome do país")]
        public string CountryName { get; set; } = "";

        [Display(Name = "Código do país")]
        public string CountryCode { get; set; } = "";
    }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        NewCountry = new Country
        {
            CountryName = Input.CountryName,
            CountryCode = Input.CountryCode
        };
    }
}
