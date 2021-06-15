﻿using MostriVsEroi.Modelli;
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
            
            Eroe e1 = new Eroe("PrimoEroe", "Guerriero", 1, new Arma("Ascia", 8), 20, 0);
            Eroe e2 = new Eroe("SecondoEroe", "Mago", 2, new Arma("Onda d'urto", 15), 40, 0);
            eroi.Add(e1);
            eroi.Add(e2);
            return eroi;
        }

        public void AddEroi(Eroe e)
        {
            eroi.Add(e);
        }

        public void RemoveEroe(Eroe e)
        {
            eroi.Remove(e);
        }
    }
}