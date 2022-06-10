﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.ViewModel
{
    public class SerieViewModel
    {
        public Guid Id { get; set; }
        public Guid IdFilme { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Temporadas { get; set; }
        public int Emmies { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
    }
}
