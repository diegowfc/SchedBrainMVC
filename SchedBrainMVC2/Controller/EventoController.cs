using Microsoft.EntityFrameworkCore;
using SchedBrainMVC2.Data;
using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Controller
{
    internal class EventoController
    {
        protected static DataContext Context = new DataContext();

        private static void ValidaEvento(Evento evento)
        {
            if(evento.Foto == "") throw new Exception("Escolha uma foto");

            if (evento.NomeEvento.Trim() == "") throw new Exception("Nome vazio");

            if(evento.LocalEvento.Trim() == "") throw new Exception("Local vazio");

            if (evento.DataInicio.Date > evento.DataTermino.Date) throw new Exception("Data inválida");

            if (evento.DescricaoEvento.Trim() == "") throw new Exception("Descrição vazia");

            if(evento.Periodicidade.Trim() == "") throw new Exception("Escolha uma periodicidade");

            if(evento.Status.Trim() == "") throw new Exception("Status vazio");
        }

        internal static void InsereEvento(Evento evento)
        {
            ValidaEvento(evento);
            Context.Add(evento);
            Context.SaveChanges();
        }

        internal static void ExcluiEvento(string nome)
        {
            Evento eventoAlvo = Context.Eventos.FirstOrDefault(x => x.NomeEvento == nome)!;
            Context.Eventos.Remove(eventoAlvo);
            Context.SaveChanges();
        }

        internal static void EditaEvento(Evento evento)
        {
            ValidaEvento(evento);

            Context.Eventos.Update(evento).
            Context.SaveChanges();
        }

        internal static void ConcluiEvento(string nome)
        {
            Evento eventoAlvo = Context.Eventos.FirstOrDefault(x => x.NomeEvento == nome)!;
            eventoAlvo.Status = "Concluido";
            Context.Update(eventoAlvo);
            Context.SaveChanges();
        }

        /// <summary>
        /// Exibe os eventos que estão próximos do prazo de término.
        /// </summary>
        /// <returns></returns>

        internal static List<Evento> retornaEventoAtual()
        {
            return Context.Eventos.Where(
                x => x.DataTermino == DateTime.Today & x.Status == "Em Andamento" || 
                ((x.DataTermino.Day - DateTime.Today.Day <= 3) 
                && x.DataTermino.Month == DateTime.Today.Month 
                && x.DataTermino.Year == DateTime.Today.Year && x.Status == "Em Andamento"))
                .ToList();
        }

        internal static List<Evento> ListaEvento()
        {
            return Context.Eventos.OrderBy(x => x.DataInicio).ThenBy(x => x.DataTermino).ToList();
        }

        /// <summary>
        /// Retorna o evento escolhido para edição.
        /// </summary>
        /// <param name="nomeEvento"></param>
        /// <returns></returns>
        internal static Evento retornaEvento(string nomeEvento)
        {
            return Context.Eventos.Where(x => x.NomeEvento == nomeEvento).FirstOrDefault();
        }
    }
}
