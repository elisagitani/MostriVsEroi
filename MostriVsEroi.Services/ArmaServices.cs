using MostriVsEroi.DbManager;
using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public static class ArmaServices
    {
        //static ArmaMockRepository amr = new ArmaMockRepository();
        static DbManagerArmi amr = new DbManagerArmi();
        public static List<Arma> GetArmi(Utente utente, string categoria)
        {
            return amr.FetchArmi(categoria);
        }

        public static int RecuperaIdArmi(Arma arma)
        {
            return amr.RecuperaIdArma(arma);
        }
    }
}
