using MostriVsEroi.Services;
using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.View
{
    class GiocaView
    {
        public static void Gioca(Utente utente, int idUtente)
        {
            //Scelta eroe

            Eroe e = SceltaEroe(utente,idUtente);
            if (e != null)
            {
                Console.WriteLine("Eroe selezionato con successo");
                int idEroe = EroeServices.RecuperaIdEroe(e, utente, idUtente);
                Mostro m = SceltaMostro(utente, e);
                Console.WriteLine($"\nIl mostro selezionato dal sistema è: {m.Nome} \nCaratteristiche mostro:\nLivello: {m.Livello} \nPunti vita: {m.PuntiVita} \nCategoria {m.Categoria} \nArma: {m.Arma.Nome} avente punti danno pari a {m.Arma.PuntiDanno}");
                int puntiVitaMostro = m.PuntiVita;
                int puntiVitaEroe = e.PuntiVita;
                Partita(utente, e, m, puntiVitaMostro, puntiVitaEroe, idUtente, idEroe);
                
                string scelta;


                Console.WriteLine("Vuoi giocare ancora? si/no");
                scelta = Console.ReadLine();


                if (scelta == "SI" || scelta == "si")
                {
                    Gioca(utente,idUtente);
                }
                else
                {
                    if (!utente.IsAdmin)
                    {
                        Menu.MenuNonAdmin(utente,idUtente);
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

        private static Utente ControlloUtenteAdmin(Utente utente, int idUtente)
        {
            List<Eroe> eroi = EroeServices.GetEroi(utente, idUtente);

            foreach(var eroe in eroi)
            {
                if (eroe.Livello == 3)
                {
                    utente.IsAdmin = true;
                }
            }

            return utente;
        }

        private static void ControlloPunteggio(Utente utente, int idUtente)
        {
            List<Eroe> eroi = EroeServices.GetEroi(utente, idUtente);

            foreach(var eroe in eroi)
            {
                if (eroe.PuntiAccumulati > 29 && eroe.Livello==1)
                {
                    AumentoLivello(eroe, utente, idUtente);   
                }
                if (eroe.PuntiAccumulati > 59 && eroe.Livello==2)
                {
                    AumentoLivello(eroe, utente, idUtente);
                }
                if (eroe.PuntiAccumulati > 89 && eroe.Livello==3)
                {
                    AumentoLivello(eroe, utente, idUtente);
                }
                if (eroe.PuntiAccumulati > 119 & eroe.Livello==4)
                {
                    AumentoLivello(eroe, utente, idUtente);
                }

            }
        }

        private static void AumentoLivello(Eroe e, Utente utente, int idUtente)
        {
            e.Livello += 1;
            int idEroe = EroeServices.RecuperaIdEroe(e, utente, idUtente); //Recupero idEroe
            int idLivello = LivelloVitaService.RecuperaIdLivelloVita(e); //Recupero idLivello
            e.PuntiAccumulati = 0;
            EroeServices.UpdatePunteggio(e, idEroe, idLivello);
        }

        private static Eroe CalcoloPunteggio(int livelloMostro, Eroe e)
        {
            e.PuntiAccumulati += livelloMostro * 10;
         
            return e;
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

        public static void Partita(Utente utente, Eroe eroe, Mostro mostro, int puntiVitaMostro, int puntiVitaEroe, int idUtente, int idEroe)
        {
            //Attacco
           
            Console.WriteLine($"\n{eroe.Nome} Attacca {mostro.Nome}");
            
            int nuoviPuntiVitaMostro = puntiVitaMostro - eroe.Arma.PuntiDanno;
            if (nuoviPuntiVitaMostro <= 0)
            {
                Console.WriteLine("Hai vinto!!");
                ControlliPartita(eroe, mostro, utente, idUtente, idEroe);
                

            }
            else
            {

                Console.WriteLine($"{mostro.Nome} dopo l'attacco ha ancora {nuoviPuntiVitaMostro} punti vita");
                Console.WriteLine($"\n{mostro.Nome} Attacca {eroe.Nome}");
                int nuoviPuntiVitaEroe = puntiVitaEroe - mostro.Arma.PuntiDanno;
                Console.WriteLine($"{eroe.Nome} dopo l'attacco di {mostro.Nome} ha ancora {nuoviPuntiVitaEroe} punti vita");

                if (nuoviPuntiVitaEroe <= 0)
                {

                    Console.WriteLine("\nHai perso!!");
                   

                }
                else
                {
                    puntiVitaMostro = nuoviPuntiVitaMostro;
                    puntiVitaEroe = nuoviPuntiVitaEroe;
                    Partita(utente, eroe, mostro, puntiVitaMostro, puntiVitaEroe, idUtente,idEroe);
                    
                }

            }

            
        }

        private static void ControlliPartita(Eroe e, Mostro m, Utente utente, int idUtente,int idEroe)
        {
            e = CalcoloPunteggio(m.Livello, e);
            Console.WriteLine($"{e.Nome} ha accumulato {e.PuntiAccumulati} punti");
            int idLivelloEroe = LivelloVitaService.RecuperaIdLivelloVita(e);
            EroeServices.UpdatePunteggio(e, idEroe, idLivelloEroe);
            //Devo controllae il punteggio degli eroi dell'utente 
            ControlloPunteggio(utente, idUtente);
            //DevoControllare se utente può diventare admin

            utente = ControlloUtenteAdmin(utente, idUtente);
            UtenteServices.UpdateUtente(utente, idUtente);
        }

        public static Eroe SceltaEroe(Utente utente,int idUtente)
        {
            Console.WriteLine("Con quale eroe vuoi iniziare la partita?");
            List<Eroe> eroi = EroeServices.GetEroi(utente,idUtente);
            
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

