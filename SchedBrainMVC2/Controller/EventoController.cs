using SchedBrainMVC2.Data;
using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Controller
{
    public class EventoController
    {
        internal static void Salvar(Evento evento)
        {
            DataContext Context = new DataContext();
            Context.Add(evento);
            Context.SaveChanges();
        }
    }
}
