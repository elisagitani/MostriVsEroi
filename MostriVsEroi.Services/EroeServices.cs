using MostriVsEroi.Modelli;
using MostriVsEroi.MockRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Services
{
    public static class EroeServices
    {
        static EroeMockRepository emr = new EroeMockRepository();
        public static List<Eroe> GetEroi(Utente utente)
        {
            return emr.FetchEroi();
        }

        public static void AddEroe(Utente utente, Eroe e)
        {
            emr.AddEroi(e);
        }

        public static void RemoveEroe(Utente utente, Eroe e)
        {
            emr.RemoveEroe(e);
        }
    }
}
