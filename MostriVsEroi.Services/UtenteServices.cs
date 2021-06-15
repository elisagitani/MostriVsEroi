using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;

namespace MostriVsEroi.Services
{
    public static class UtenteServices
    {
        static UtenteMockRepository umr = new UtenteMockRepository();
        public static Utente VerifyAuthentication(Utente utente)
        {
            return umr.GetUser(utente);
        }
    }
}
