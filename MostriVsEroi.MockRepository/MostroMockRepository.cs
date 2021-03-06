using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.MockRepository
{
    public class MostroMockRepository : IMostroRepository
    {
        public List<Mostro> FetchMostri()
        {
            List<Mostro> mostri = new List<Mostro>();
            Mostro m1 = new Mostro("Mostro1", "Cultista", new Arma("Farneticazione", 7), 1, 20);
            Mostro m2 = new Mostro("Mostro2", "Orco", new Arma("Clava", 5), 2, 40);
            Mostro m3 = new Mostro("Mostro3", "Signore del male", new Arma("Divinazione", 15), 2, 40);
            Mostro m4 = new Mostro("Mostro4", "Signore del male", new Arma("Fulmine", 10), 1, 20);
            //Mostro m5 = new Mostro("Mostro5", "Orco", new Arma("Spada Rotta", 3), 2, 40);
            mostri.Add(m1);
            mostri.Add(m2);
            mostri.Add(m3);
            mostri.Add(m4);

            return mostri;

        }

        public void AddMostro(Mostro m, int idCategoria, int idArma, int idLivello)
        {

        }


        public bool VerificaNome(string nome)
        {
            return true;
        }
    }
}