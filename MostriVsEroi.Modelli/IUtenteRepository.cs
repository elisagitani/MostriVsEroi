using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IUtenteRepository
    {
        public Utente GetUser(Utente utente);
        public List<Utente> FetchUtenti();
        public void AddUtente(Utente utente);
    }
}
