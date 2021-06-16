using MostriVsEroi.Modelli;
using MostriVsEroi.MockRepository;
using System;
using System.Collections.Generic;
using System.Text;
using MostriVsEroi.DbManager;

namespace MostriVsEroi.Services
{
    public static class CategoriaServices
    {
        //static CategoriaMockRepository cmr = new CategoriaMockRepository();
        static DbManagerCategorie cmr = new DbManagerCategorie();
        public static List<string> GetCategoriaEroi(Utente utente)
        {
            return cmr.FetchCategorieEroi();
        }
    }
}