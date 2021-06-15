using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IUtenteRepository
    {
        public Utente GetUser(Utente utente);
    }
}
