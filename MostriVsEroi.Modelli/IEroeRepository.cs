using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IEroeRepository
    {
        //public List<Eroe> FetchEroi();
        public void AddEroi(Utente u,Eroe e);
        //public bool RemoveEroe(Eroe e);
    }
}

