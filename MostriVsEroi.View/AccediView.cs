using MostriVsEroi.Modelli;
using MostriVsEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    static class AccediView
    {
        public static void Accedi()
        {
            Utente utente = RichiestaDati.InserisciUsernamePassword();
            utente = UtenteServices.VerifyAuthentication(utente);
            if (utente.IsAuthenticated && utente.IsAdmin)
            {
                //MenuAdmin
            }
            else if (utente.IsAuthenticated && !utente.IsAdmin)
            {
                Menu.MenuNonAdmin(utente);
            }
            else
            {
                Console.WriteLine("\nCredenziali inserite non corrette, non risulti registrato");
                Console.WriteLine();
            }
        }
    }
}
