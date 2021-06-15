using MostriVsEroi.Modelli;
using MostriVsEroi.MockRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public static class CategoriaServices
    {
        static CategoriaMockRepository cmr = new CategoriaMockRepository();
        public static List<string> GetCategoriaEroi(Utente utente)
        {
            return cmr.FetchCategorieEroi();
        }
    }
}