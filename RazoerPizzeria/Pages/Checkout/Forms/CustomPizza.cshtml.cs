using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazoerPizzeria.Models;

namespace RazoerPizzeria.Pages.Forms
{

    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
    public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
    /* public IActionResult OnGet()
    {
           
        }*/
        
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 1;
            // the new thing make pizza object
            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });

        }
          



    }


       

}
  
    
