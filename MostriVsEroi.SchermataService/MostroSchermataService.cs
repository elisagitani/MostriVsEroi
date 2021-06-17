using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.SchermataServices
{
    public class MostroSchermataService
    {
        public static Mostro GetMostro(string nome, string categoria, int livello, string nomeArma, int puntiDanno,int puntiVita)
        {

            return new Mostro(nome, categoria, new Arma(nomeArma, puntiDanno),livello, puntiVita);


        }
    }
}
