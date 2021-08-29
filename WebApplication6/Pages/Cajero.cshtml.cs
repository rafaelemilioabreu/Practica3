using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class CajeroModel : PageModel
    {

        int mil = 9;
        int quiniento = 19;
        int cien = 99;
        public List<string> bancos = new List<string>();
        public int retirado;
        public int billetesmil;
        public int billetesquinientos;
        public int billetescien;

        public int Retirar(int monto, string banco)
        {
            int total = 0;
            if (banco == "ABC")
            {
                
                if (monto > 10000 || monto < 2000)
                {

                    total = 0;

                }

                else
                {
                    int miles = 0;

                    while (monto >= 1000 && mil > 0)
                    {
                        mil -= 1;
                        miles += 1;
                        monto -= 1000;
                    }
                    total = miles * 1000;
                    billetesmil = miles;

                    int quinientos = 0;
                    while (monto >= 500 && quiniento > 0)
                    {
                        quiniento -= 1;
                        quinientos += 1;
                        monto -= 500;

                    }

                    total += (quinientos * 500);
                    billetesquinientos = quinientos;


                    int cientos = 0;

                    while (monto >= 100 && cien > 0)
                    {
                        cien -= 1;
                        cientos += 1;
                        monto -= 100;


                    }

                    total += (cientos * 100);
                    billetescien = cientos;
                }


            }

            else
            {
                int miles = 0;

                while (monto >= 1000 && mil > 0)
                {
                    mil -= 1;
                    miles += 1;
                    monto -= 1000;
                }
                total = miles * 1000;
                billetesmil = miles;

                int quinientos = 0;
                while (monto >= 500 && quiniento > 0)
                {
                    quiniento -= 1;
                    quinientos += 1;
                    monto -= 500;

                }

                total += (quinientos * 500);
                billetesquinientos = quinientos;


                int cientos = 0;

                while (monto >= 100 && cien > 0)
                {
                    cien -= 1;
                    cientos += 1;
                    monto -= 100;


                }

                total += (cientos * 100);
                billetescien = cientos;
            }


            return total;
        }








        

           
        

        






        public void OnGet(int monto, string banco)
        {
            bancos.Add("ABC");
            bancos.Add("BCA");

            retirado = Retirar(monto, banco);
        }
    }
}
