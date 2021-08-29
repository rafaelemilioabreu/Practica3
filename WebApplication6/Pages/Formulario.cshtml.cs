using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class FormularioModel : PageModel
    {
        public double Mensual(double monto, double cuota, double interes)
        {
            double deuda = monto * interes / 100;
            double total = monto + deuda;
            double mensual = total / cuota;
            return Math.Round(mensual);
        }

        public double mensual { get; set; }
        public void OnGet(double monto, double cuota, double interes)
        {
            mensual = Mensual(monto, cuota, interes);
            
        }
    }
}
