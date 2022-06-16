using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Model
{
    public class EventoContato
    {
        public int Id { get; set; }

        public Contato Contato { get; set; }
        public int ContatoId { get; set; }

        [NotMapped]
        public string NomeContato
        {
            get
            {
                if (Contato != null)
                    return Contato.Nome;

                return "";
            }
        }

        public Evento Evento { get; set; }
        public int EventoId { get; set; }
    }
}
