using MostriVsEroi.DbManager;
using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;

namespace MostriVsEroi.Services
{
    public static class UtenteServices
    {
        //static UtenteMockRepository umr = new UtenteMockRepository();
        static DbManagerUtenti umr = new DbManagerUtenti();
        public static Utente VerifyAuthentication(Utente utente)
        {
            return umr.GetUser(utente);
        }

        public static List<Utente> FetchUtenti()
        {
            return umr.FetchUtenti();
        }

        public static void AddUtente(Utente utente)
        {
            umr.AddUtente(utente);
        }

        public static int RecuperaIdUtente(Utente u)
        {
            return umr.RecuperaIdUtente(u.Username);
        }

        public static void UpdateUtente(Utente utente, int idUtente)
        {
            umr.UpdateUtente(utente, idUtente);
        }
    }
}
