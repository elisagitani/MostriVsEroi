using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;

namespace MostriVsEroi.MockRepository
{
    public class UtenteMockRepository : IUtenteRepository
    {
        public Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            return utente;
        }

        public List<Utente> FetchUtenti()
        {
            Utente u = new Utente("ely.95", "12345");
            List<Utente> utenti = new List<Utente>();
            utenti.Add(u);
            return utenti;
        }

        public void AddUtente(Utente utente)
        {

        }
        public int RecuperaIdUtente(string user)
        {
            return 0;
        }

        public void UpdateUtente(Utente utente, int idUtente)
        {

        }
    }
}
