using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IMostroRepository
    {
        public List<Mostro> FetchMostri();
    }
}