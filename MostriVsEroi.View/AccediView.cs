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
                int idUtente = UtenteServices.RecuperaIdUtente(utente);
                Menu.MenuAdmin(utente, idUtente);
                //return;
            }
            else if (utente.IsAuthenticated && !utente.IsAdmin)
            {
                int idUtente = UtenteServices.RecuperaIdUtente(utente);
                Menu.MenuNonAdmin(utente,idUtente);
                //return;
            }
            else
            {
                Console.WriteLine("\nCredenziali inserite non corrette, non risulti registrato");
                Console.WriteLine();
            }
        }
    }
}
