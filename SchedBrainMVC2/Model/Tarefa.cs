using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Model
{
    public class Tarefa
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }

        [MaxLength(26)]
        public string Titulo { get; set; }

        [MaxLength(2130)]
        public string? Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataMaximaConclusao { get; set; }

        public string Prioridade { get; set; }

        public string Anexos { get; set; }

        public Contato Contato { get; set; }
        public int? ContatoId { get; set; }

        public Evento Evento { get; set; }
        public int? EventoId { get; set; }


        public string Situacao { get; set; }

        public bool Lembrete { get; set; }
    }
}
