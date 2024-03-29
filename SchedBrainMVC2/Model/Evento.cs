﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Model
{
    public class Evento
    {
        [Required]
        public int ID { get; set; }
        
        public string NomeEvento { get; set; }

        public string LocalEvento { get; set; }

        public string DescricaoEvento { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataTermino { get; set; }

        public string Periodicidade { get; set; }

        public string Status { get; set; }

        public string Foto { get; set; }
    }

}
