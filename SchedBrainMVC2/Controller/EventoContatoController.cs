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
    internal class EventoContatoController
    {
        protected static DataContext Context = new DataContext();

        internal static void InsereEventoContato(EventoContato eventoContato)
        {
            Context.Add(eventoContato);
            Context.SaveChanges();
        }

        internal static void ExcluiEventoContato(int contatoID, int eventoID)
        {
            EventoContato eventoContatoAlvo = Context.EventoContato.Where(x => x.ContatoId == contatoID && x.EventoId == eventoID).FirstOrDefault();
            Context.EventoContato.Remove(eventoContatoAlvo);
            Context.SaveChanges();
        }

        internal static List<EventoContato> retornaNomeContato(int idEvento, int idContato)
        {
            return Context.EventoContato.Include(x => x.Contato).Where(x => x.ContatoId == idContato && x.EventoId == idEvento).ToList();
        }


        internal static List<EventoContato> ListaContatosAtribuidos()
        {
            return Context.EventoContato.ToList();
        }
    }
}
