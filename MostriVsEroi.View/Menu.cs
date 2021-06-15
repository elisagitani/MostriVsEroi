using MostriVsEroi.Modelli;
using System;

namespace MostriVsEroi.View
{
    public static class Menu
    {
        public static void MainMenu()
        {
            bool vuoiContinuare = true;

            do
            {
                Console.WriteLine("Bentornato!");
                Console.WriteLine();
                Console.WriteLine("Cosa vuoi fare?");

                Console.WriteLine("Premi 1 per Accedere");
                Console.WriteLine("Premi 2 per Registrarti");
                Console.WriteLine("Premi 0 per Uscire");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        //Devo far accedere l'utente
                        AccediView.Accedi();
                        break;
                    case "2":
                        //Devo far registrare l'utente 
                        break;
                    case "0":
                        Console.WriteLine("Ciao alla prossima");
                        vuoiContinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata......Riprova");
                        break;
                }
            } while (vuoiContinuare);
        }

        public static void MenuNonAdmin(Utente utente)
        {
            bool vuoiContinuare = true;

            do
            {
                Console.WriteLine($"\nBentornato {utente.Username}");
                Console.WriteLine();
                Console.WriteLine("Cosa vuoi fare?");

                Console.WriteLine("Premi 1 per Giocare");
                Console.WriteLine("Premi 2 per Creare un nuovo eroe");
                Console.WriteLine("Premi 3 per Eliminare un eroe");
                Console.WriteLine("Premi 0 per Uscire");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        //Giocare
                        GiocaView.Gioca(utente);
                        break;
                    case "2":
                        CreaUnNuovoEroeView.CreaNuovoEroe(utente);
                        break;
                    case "3":
                        EliminaEroeView.EliminaEroe(utente);
                        break;
                    case "0":
                        MainMenu();
                        vuoiContinuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata......Riprova");
                        break;
                }
            } while (vuoiContinuare);
        }
    }
}
