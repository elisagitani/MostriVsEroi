using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public static class MostroServices
    {
        static MostroMockRepository mmr = new MostroMockRepository();
        public static List<Mostro> GetMostri(Utente utente)
        {
            return mmr.FetchMostri();
        }
    }
}
