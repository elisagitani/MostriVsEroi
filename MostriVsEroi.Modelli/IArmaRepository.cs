using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IArmaRepository
    {
        public List<Arma> FetchArmiEroi(string categoria);
    }
}
