using MostriVsEroi.Modelli;
using System;

namespace MostriVsEroi.MockRepository
{
    public class UtenteMockRepository : IUtenteRepository
    {
        public Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            return utente;
        }
    }
}
