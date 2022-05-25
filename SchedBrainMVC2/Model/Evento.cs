using System;
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

        public string Contato { get; set; }

        public string Status { get; set; }

        public string Foto { get; set; }

        public Evento(string nome, string local, string descricao, DateTime dataInicio, DateTime dataTermino, string periodicidade, string status, string contato, string imagem)
        {
            NomeEvento = nome;
            LocalEvento = local;
            DescricaoEvento = descricao;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Periodicidade = periodicidade;
            Status = status;
            Foto = imagem;
            Contato = contato;
        }

    }

}
