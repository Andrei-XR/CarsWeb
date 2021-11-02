using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarsWeb.Models;
using CarsWeb.Services;

namespace CarsWeb.Pages
{
    public class CarModel : PageModel
    {
        [BindProperty]
        public Carro Carro { get; set; }
        public List<Carro> Carros { get; set;} 

        public void OnGet()
        {
            Carros = CarroService.GetAll();
        }

        public IActionResult OnPostAsync() {

            if (!ModelState.IsValid) {

                return Page();
            }

            CarroService.Add(Carro);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id) {

            CarroService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
