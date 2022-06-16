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

        private void button2_Click(object sender, EventArgs e)
        {
            EventoView ev = new EventoView();
            ev.ShowDialog();
        }

        private void PrincipalView_Activated(object sender, EventArgs e)
        {
            List<Evento> listaEventos = EventoController.retornaEventoAtual();
            List<Contato> listaContatos = ContatoController.retornaFavoritos();

            flpEventoPrincipal.Controls.Clear();
            flpContatoPrincipal.Controls.Clear();

            foreach (Evento evento in listaEventos)
            {
                EventoControlView ec = new EventoControlView(flpEventoPrincipal);
                ec.SalvaEvento(evento);
                flpEventoPrincipal.Controls.Add(ec);
                ec.ContextMenuStrip = null;
            }

            foreach (Contato contato in listaContatos)
            {
                ContatoControlView cc = new ContatoControlView(flpContatoPrincipal);
                cc.SalvaContato(contato);
                flpContatoPrincipal.Controls.Add(cc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContatoView contato = new ContatoView();
            contato.ShowDialog();
        }
    }
}
