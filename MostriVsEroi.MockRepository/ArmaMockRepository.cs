using System;
using System.Collections.Generic;
using System.Text;
using MostriVsEroi.Modelli;

namespace MostriVsEroi.MockRepository
{
    public class ArmaMockRepository:IArmaRepository
    {

        public List<Arma> FetchArmiEroi(string categoria)
        {
            List<Arma> armi = new List<Arma>();
            Arma a1 = new Arma("Alabarda", 15);
            Arma a2 = new Arma("Ascia", 8);
            Arma a3 = new Arma("Mazza", 5);
            Arma a4 = new Arma("Bacchetta", 5);
            Arma a5 = new Arma("Bastone magico", 10);
            Arma a6 = new Arma("Arco e Frecce", 8);
            armi.Add(a1);
            armi.Add(a2);
            armi.Add(a3);
            armi.Add(a4);
            armi.Add(a5);
            armi.Add(a6);
            return armi;

        }
    }
}
