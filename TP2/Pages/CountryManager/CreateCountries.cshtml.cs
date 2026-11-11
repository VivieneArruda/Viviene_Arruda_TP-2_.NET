// Exercício: 7
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2.Models;

namespace TP2.Pages.CountryManager;

public class CreateCountriesModel : PageModel
{
    [BindProperty]
    public List<InputModel> Countries { get; set; } = new();

    public List<Country> Saved { get; set; } = new();

    public class InputModel
    {
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
    }

    public void OnGet()
    {
        for (var i = 0; i < 5; i++)
        {
            Countries.Add(new InputModel());
        }
    }

    public void OnPost()
    {
        foreach (var item in Countries)
        {
            if (string.IsNullOrWhiteSpace(item.CountryName))
            {
                continue;
            }

            Saved.Add(new Country
            {
                CountryName = item.CountryName,
                CountryCode = item.CountryCode ?? ""
            });
        }
    }
}
