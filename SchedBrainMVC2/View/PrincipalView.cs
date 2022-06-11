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

        private void PrincipalView_Load(object sender, EventArgs e)
        {
            List<Evento> listaEventos = EventoController.retornaEventoAtual();
            flpEventoPrincipal.Controls.Clear();

            foreach (Evento evento in listaEventos)
            {
                EventoControlView ec = new EventoControlView(flpEventoPrincipal);
                ec.SalvaEvento(evento);
                flpEventoPrincipal.Controls.Add(ec);
                ec.ContextMenuStrip = null;
            }
        }
    }
}
