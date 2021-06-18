using MostriVsEroi.Modelli;
using MostriVsEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    public class ClassificaGlobaleView
    {
        internal static void Classifica()
        {
            Console.WriteLine("------------------------------------------------------Top 10 Eroi------------------------------------------------------------------");
            Console.WriteLine();

            Dictionary<Eroe,string> classifica = EroeServices.RecuperaClassifica();

            foreach(var item in classifica)
            {
                Console.WriteLine($"Username: {item.Value} \tNome Eroe:{item.Key.Nome} \tCategoria: {item.Key.Categoria} \tLivello: {item.Key.Livello} \tPunti Vita: {item.Key.PuntiVita} \tPunti Accumulati: {item.Key.PuntiAccumulati}");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
            }

        }
    }
}
