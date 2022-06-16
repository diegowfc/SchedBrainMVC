using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Model
{
    public class Contato
    {
        [Required]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Apelido { get; set; }

        public string Email { get; set; }

        public string? Imagem { get; set; }

        public string Telefone { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        public bool Favorito { get; set; } = false;
        
        public string Tipo { get; set; }
    }
}
