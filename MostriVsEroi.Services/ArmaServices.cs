using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public static class ArmaServices
    {
        static ArmaMockRepository amr = new ArmaMockRepository();
        public static List<Arma> GetArmi(Utente utente)
        {
            return amr.FetchArmi();
        }
    }
}
