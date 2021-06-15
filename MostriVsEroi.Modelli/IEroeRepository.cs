using System;
using System.Collections.Generic;
using System.Text;

namespace MostriVsEroi.Modelli
{
    public interface IEroeRepository
    {
        public List<Eroe> FetchEroi();
        public void AddEroi(Eroe e);
        public bool RemoveEroe(Eroe e);
    }
}

