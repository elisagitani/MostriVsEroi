using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IArmaRepository
    {
        public List<Arma> FetchArmi(string categoria);
        public int RecuperaIdArma(Arma arma);
    }
}
