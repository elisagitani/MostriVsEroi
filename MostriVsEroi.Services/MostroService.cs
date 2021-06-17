using MostriVsEroi.DbManager;
using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public static class MostroServices
    {
        //static MostroMockRepository mmr = new MostroMockRepository();
        static DbManagerMostri mmr = new DbManagerMostri();
        public static List<Mostro> GetMostri(Utente utente)
        {
            return mmr.FetchMostri();
        }

        public static bool VerificaNome(string nome)
        {
            return mmr.VerificaNome(nome);
        }

        public static void AddMostro(Mostro m, int idCategoria, int idArma, int idLivello)
        {
            mmr.AddMostro(m,idCategoria,idArma,idLivello);
        }
    }
}
