﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string morada { get; set; }
        public string email { get; set; }
        public int maxSalas { get; set; }

        public Cinema() 
        {
        
        
        }
    }
}
