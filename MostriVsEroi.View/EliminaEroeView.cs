using MostriVsEroi.Modelli;
using MostriVsEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    public class EliminaEroeView
    {
        internal static void EliminaEroe(Utente utente)
        {
            Eroe e = ScegliEroeDaEliminare(utente);
            if (e != null)
            {
                EroeServices.RemoveEroe(utente, e);
                Console.WriteLine("Eroe eliminato con successo");
            }

        }

        public static Eroe ScegliEroeDaEliminare(Utente utente)
        {
            Console.WriteLine("Quale eroe vuoi eliminare?");
            List<Eroe> eroi = EroeServices.GetEroi(utente);

            int scelta;
            if (eroi.Count > 0)
            {
                do
                {
                    int count = 1;
                    foreach (var eroe in eroi)
                    {
                        Console.WriteLine($"\nPremi {count} per eliminare l'eroe {eroe.Nome}, di tipo {eroe.Categoria} di livello {eroe.Livello} e punti vita {eroe.PuntiVita} con arma {eroe.Arma.Nome} che ha {eroe.Arma.PuntiDanno} punti danno");

                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        count++;
                    }


                } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > eroi.Count);

                return eroi[--scelta];
            }
            else
            {
                Console.WriteLine("Non possiedi eroi");
                return null;
            }

        }
    }
}
