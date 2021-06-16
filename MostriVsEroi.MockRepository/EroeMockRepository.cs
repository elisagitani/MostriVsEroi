using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.MockRepository
{
    public class EroeMockRepository : IEroeRepository
    {

        List<Eroe> eroi = new List<Eroe>();
        public List<Eroe> FetchEroi()
        {
            List<Eroe> eroi = new List<Eroe>();
            Eroe e1 = new Eroe("PrimoEroe", "Guerriero", 1, new Arma("Ascia", 8), 20, 0);
            Eroe e2= new Eroe("SecondoEroe", "Mago", 2, new Arma("Onda d'urto", 15), 40, 0);
            eroi.Add(e1);
            eroi.Add(e2);
           
            return eroi;
        
        }


        public void AddEroi(Utente u,Eroe e)
        {
            eroi.Add(e);
            
        }

        public bool RemoveEroe(Eroe e)
        {

            return eroi.Remove(e);

        }
    }
}