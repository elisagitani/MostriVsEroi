using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IEroeRepository
    {
        public List<Eroe> FetchEroi(Utente utente, int idUtente);
        public void AddEroi(Utente u, int idUtente, Eroe e, int idCategoria, int idArma, int idLivello);
        public void RemoveEroe(Eroe e, Utente u, int idEroe);
    }
}

