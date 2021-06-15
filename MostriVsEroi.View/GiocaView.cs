using MostriVsEroi.Services;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    class GiocaView
    {
        public static void Gioca(Utente utente)
        {
            //Scelta eroe

            Eroe e = SceltaEroe(utente);
            if (e != null)
            {
                Console.WriteLine("Eroe selezionato con successo");
                Mostro m = SceltaMostro(utente, e);
                Console.WriteLine($"\nIl mostro selezionato dal sistema è: {m.Nome} \nCaratteristiche mostro:\nLivello: {m.Livello} \nPunti vita: {m.PuntiVita} \nCategoria {m.Categoria} \nArma: {m.Arma.Nome} avente punti danno pari a {m.Arma.PuntiDanno}");
                Partita(utente, e, m);

                string scelta;


                Console.WriteLine("Vuoi giocare ancora? si/no");
                scelta = Console.ReadLine();


                if (scelta == "SI" || scelta == "si")
                {
                    Gioca(utente);
                }
                else
                {
                    if (!utente.IsAdmin)
                    {
                        Menu.MenuNonAdmin(utente);
                    }
                    else
                    {

                        //Menu.MenuAdmin(utente);
                    }

                }

            }
            else
            {
                Console.WriteLine("Corri a creare un nuovo eroe");
            }

        }

        private static Mostro SceltaMostro(Utente utente, Eroe eroe)
        {
            List<Mostro> mostri = MostroServices.GetMostri(utente);
            Random r = new Random();
            int scelta = r.Next(0, mostri.Count);

            if (mostri[scelta].Livello <= eroe.Livello)
            {
                return mostri[scelta];
            }
            else
            {
                return SceltaMostro(utente, eroe);
            }


        }

        public static void Partita(Utente utente, Eroe eroe, Mostro mostro)
        {
            //Attacco

            Console.WriteLine($"\n{eroe.Nome} Attacca {mostro.Nome}");
            int nuoviPuntiVitaMostro = mostro.PuntiVita - eroe.Arma.PuntiDanno;
            if (nuoviPuntiVitaMostro <= 0)
            {
                Console.WriteLine("Hai vinto!!");
                //Chiamo funzionalità che calcola nuovo punteggio

            }
            else
            {

                Console.WriteLine($"{mostro.Nome} dopo l'attacco ha ancora {nuoviPuntiVitaMostro} punti vita");
                Console.WriteLine($"\n{mostro.Nome} Attacca {eroe.Nome}");
                int nuoviPuntiVitaEroe = eroe.PuntiVita - mostro.Arma.PuntiDanno;
                Console.WriteLine($"{eroe.Nome} dopo l'attacco di {mostro.Nome} ha ancora {nuoviPuntiVitaEroe} punti vita");

                if (nuoviPuntiVitaEroe <= 0)
                {

                    Console.WriteLine("\nHai perso!!");

                }
                else
                {
                    mostro.PuntiVita = nuoviPuntiVitaMostro;
                    eroe.PuntiVita = nuoviPuntiVitaEroe;
                    Partita(utente, eroe, mostro);

                }

            }
        }

        public static Eroe SceltaEroe(Utente utente)
        {
            Console.WriteLine("Con quale eroe vuoi iniziare la partita?");
            List<Eroe> eroi = EroeServices.GetEroi(utente);
            
            int scelta;
            if (eroi.Count > 0)
            {
                do
                {
                    int count = 1;
                    foreach (var eroe in eroi)
                    {
                        Console.WriteLine($"\nPremi {count} per scegliere l'eroe {eroe.Nome}, di tipo {eroe.Categoria} di livello {eroe.Livello} e punti vita {eroe.PuntiVita} con arma {eroe.Arma.Nome} che ha {eroe.Arma.PuntiDanno} punti danno");

                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        count++;
                    }


                } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > eroi.Count);

                return eroi[--scelta];

            }
            else
            {
                return null;
            }

        }

    }
}

