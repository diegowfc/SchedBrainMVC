using SchedBrainMVC2.Controller;
using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedBrainMVC2.View
{
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void AcessaEvento_Click(object sender, EventArgs e)
        {
            EventoView ev = new EventoView();
            ev.ShowDialog();
        }

        private void PrincipalView_Activated(object sender, EventArgs e)
        {
            List<Evento> listaEventos = EventoController.retornaEventoAtual();
            List<EventoContato> listaIds = EventoContatoController.ListaContatosAtribuidos();
            List<Contato> listaContatos = ContatoController.retornaFavoritos();
            List<Tarefa> listaTarefas = TarefaController.retornaTarefaPrioritaria();

            flpEventoPrincipal.Controls.Clear();
            flpContatoPrincipal.Controls.Clear();
            flpTarefaPrincipal.Controls.Clear();

            foreach (Evento evento in listaEventos)
            {
                EventoControlView ec = new EventoControlView(flpEventoPrincipal);
                ec.SalvaEvento(evento);
                flpEventoPrincipal.Controls.Add(ec);
                foreach (EventoContato contatoID in listaIds)
                {
                    if (contatoID.EventoId == evento.ID)
                        ec.SalvaContato(evento.ID, contatoID.ContatoId);
                }
                ec.ContextMenuStrip = null;
            }

            foreach (Contato contato in listaContatos)
            {
                ContatoControlView cc = new ContatoControlView(flpContatoPrincipal);
                cc.SalvaContato(contato);
                flpContatoPrincipal.Controls.Add(cc);
            }

            foreach (Tarefa tarefa in listaTarefas)
            {
                TarefaControlView tc = new TarefaControlView(flpTarefaPrincipal);
                tc.SalvaTarefa(tarefa);
                flpTarefaPrincipal.Controls.Add(tc);
            }
        }

        private void AcessaContato_Click(object sender, EventArgs e)
        {
            ContatoView contato = new ContatoView();
            contato.ShowDialog();
        }

        private void AcessaTarefa_Click(object sender, EventArgs e)
        {
            TarefaView tarefa = new TarefaView();
            tarefa.ShowDialog();
        }
    }
}
