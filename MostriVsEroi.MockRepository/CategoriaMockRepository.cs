﻿using System;
using System.Collections.Generic;
using System.Text;
using MostriVsEroi.Modelli;

namespace MostriVsEroi.MockRepository
{
    public class CategoriaMockRepository: ICategoriaRepository
    {
        public List<string> FetchCategorieEroi()
        {
            List<string> categorie = new List<string>();
            categorie.Add("Guerriero");
            categorie.Add("Mago");
            return categorie;
        }

        
    }
}
