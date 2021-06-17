using MostriVsEroi.DbManager;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public class LivelloVitaService
    {
        static DbManagerLivelliVita lvmr = new DbManagerLivelliVita();

        public static int RecuperaIdLivelloVita(Eroe e)
        {
            return lvmr.RecuperaIdLivelliVita(e);
        }

        public static int RecuperaIdLivelloVita(Mostro m)
        {
            return lvmr.RecuperaIdLivelliVita(m);
        }

        public static int RecuperaLivelloVita(int puntiVita)
        {
            return lvmr.RecuperaLivelliVita(puntiVita);
        }

        public static Dictionary<int, int> GetLivelli()
        {
            return lvmr.GetLivelli();
        }
    }
}
