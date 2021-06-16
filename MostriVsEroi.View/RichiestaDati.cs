using MostriVsEroi.Modelli;
using MostriVsEroi.SchermataServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    static class RichiestaDati
    {
        internal static Utente InserisciUsernamePassword()
        {
            Console.Write("\nInserisci il tuo username: ");
            string username = Console.ReadLine();

            Console.Write("Inserisci la tua password: ");
            string password = Console.ReadLine();

            return UtenteSchermataServices.GetUtente(username, password);

        }

        

    }


}
