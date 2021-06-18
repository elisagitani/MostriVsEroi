using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.MockRepository
{
    public class EroeMockRepository : IEroeRepository
    {

        List<Eroe> eroi = new List<Eroe>();
        public List<Eroe> FetchEroi(Utente utente, int idUtente)
        {
            List<Eroe> eroi = new List<Eroe>();
            Eroe e1 = new Eroe("PrimoEroe", "Guerriero", 1, new Arma("Ascia", 8), 20, 0);
            Eroe e2= new Eroe("SecondoEroe", "Mago", 2, new Arma("Onda d'urto", 15), 40, 0);
            eroi.Add(e1);
            eroi.Add(e2);
           
            return eroi;
        
        }

        public void AddEroi(Utente u,int idUtente,Eroe e, int idCategoria, int idArma, int idLivello)
        {
            eroi.Add(e);
            
        }

        public void RemoveEroe(Eroe e,Utente u, int idEroe)
        {

             eroi.Remove(e);

        }

        public void UpdatePunteggio(Eroe e, int idEroe, int idLivello)
        {

        }
        public bool VerificaNome(string nome)
        {
            return true;
        }

        public int RecuperaIdEroe(Utente u, Eroe e, int idUtente)
        {
            return 0;
        }

        public Dictionary<Eroe, string> ClassificaGlobale()
        {
            Dictionary<Eroe, string> classifica = new Dictionary<Eroe, string>();
            return classifica;
        }
    }
}