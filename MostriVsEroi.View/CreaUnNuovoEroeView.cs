using MostriVsEroi.Modelli;
using MostriVsEroi.SchermataServices;
using MostriVsEroi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    public static class CreaUnNuovoEroeView
    {
        internal static void CreaNuovoEroe(Utente utente)
        {
            
            Console.Write("Inserisci il nome dell'eroe: ");
            string nome = Console.ReadLine();
           
            Console.Write("Inserisci la categoria: ");
            string categoria = SceltaCategoria(utente);
            if (categoria != null)
            {
                Console.Write("Inserisci l'arma: ");
                Arma arma = SceltaArma(utente);

                if (arma != null)
                {
                    Eroe e = EroeSchermataServices.GetEroe(nome, categoria, 1, arma.Nome, arma.PuntiDanno);
                    EroeServices.AddEroe(utente, e);
                    Console.WriteLine("Eroe inserito con successo");
                }
                else
                {
                    Console.WriteLine("Corri a inserire una nuova arma!!");
                }

            }
            else
            {
                Console.WriteLine("Corri a inserire una categoria!!");
            }

            

        }


        public static string SceltaCategoria(Utente utente)
        {
            Console.WriteLine("\nScegli una delle categorie tra quelle proposte: ");
            List<string> categorie = CategoriaServices.GetCategoriaEroi(utente);
            
            int scelta = 0;
            if (categorie.Count > 0)
            {
                
                do
                {
                    int count = 1;
                    foreach (var item in categorie)
                    {
                        Console.WriteLine($"\nPremi {count} per {item}");

                        Console.WriteLine("-------------------------------");
                        count++;

                    }

                } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > categorie.Count);

                return categorie[--scelta];
            }
            else
            {
                Console.WriteLine("Non sono presenti categorie");
                return null;
            }
        }

        public static Arma SceltaArma(Utente utente)
        {
            Console.WriteLine("\nScegli una delle armi tra quelle proposte: ");
            List<Arma> armi = ArmaServices.GetArmi(utente);
            
            int scelta = 0;
            if (armi.Count > 0)
            {
                do
                {
                    int count = 1;
                    foreach (var item in armi)
                    {
                        Console.WriteLine($"\nPremi {count++} per {item.Nome} con Punti Danno pari a {item.PuntiDanno}");

                        Console.WriteLine("-------------------------------------------------------------------------");
                        

                    }

                } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > armi.Count);

                return armi[--scelta];
            }
            else
            {
                Console.WriteLine("Non sono presenti armi");
                return null;
            }
        }
    }
}
