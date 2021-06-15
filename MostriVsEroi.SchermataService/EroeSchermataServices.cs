using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.SchermataServices
{
    public static class EroeSchermataServices
    {
        public static Eroe GetEroe(string nome, string categoria, int livello, string nomeArma, int puntiDanno)
        {
            
            return new Eroe(nome, categoria, 1, new Arma(nomeArma, puntiDanno),20,0);
            
            
        }
    }
}
