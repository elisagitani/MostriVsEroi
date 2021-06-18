using MostriVsEroi.Modelli;
using MostriVsEroi.MockRepository;
using System;
using System.Collections.Generic;
using System.Text;
using MostriVsEroi.DbManager;

namespace MostriVsEroi.Services
{
    public static class EroeServices
    {
        //static EroeMockRepository emr = new EroeMockRepository();
        static DbManagerEroi emr = new DbManagerEroi();
       
        public static List<Eroe> GetEroi(Utente utente, int idUtente)
        {
            return emr.FetchEroi(utente,idUtente);
            
        }

        public static bool VerificaNome(string nome)
        {
            return emr.VerificaNome(nome);
        }

        public static void AddEroe(Utente utente, int idUtente, Eroe e, int idCategoria, int idArma, int idLivello)
        {
            
            emr.AddEroi(utente, idUtente,e,idCategoria,idArma, idLivello);

        }

        public static void RemoveEroe(Utente utente, Eroe e,int idEroe)
        {
             emr.RemoveEroe(e, utente, idEroe);
        }

        public static int RecuperaIdEroe(Eroe e, Utente u, int idUtente)
        {
            return emr.RecuperaIdEroe(u, e, idUtente);
        }

        public static void UpdatePunteggio(Eroe e, int idEroe, int idLivello)
        {
            emr.UpdatePunteggio(e,idEroe, idLivello);
        }

        public static Dictionary<Eroe,string> RecuperaClassifica()
        {
            return emr.ClassificaGlobale();
        }
    }
}
