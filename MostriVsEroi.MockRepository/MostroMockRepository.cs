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
            mostri.Add(m1);
            mostri.Add(m2);
            mostri.Add(m3);
            mostri.Add(m4);

            return mostri;

        }
    }
}