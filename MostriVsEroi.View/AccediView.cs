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
            }
            else if (utente.IsAuthenticated && !utente.IsAdmin)
            {
                int idUtente = UtenteServices.RecuperaIdUtente(utente);
                Menu.MenuNonAdmin(utente,idUtente);
            }
            else
            {
                Console.WriteLine("\nCredenziali inserite non corrette, non risulti registrato");
                Console.WriteLine();
            }
        }
    }
}
