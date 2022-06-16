using SchedBrainMVC2.Controller;
using SchedBrainMVC2.Data;
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
    public partial class EventoControlView : UserControl
    {
        Control painel = new Control();

        public EventoControlView(FlowLayoutPanel flp)
        {
            InitializeComponent();
            painel = flp;
        }

        /// <summary>
        /// Atualiza o painel após alguma ação do usuário
        /// </summary>
        public void AtualizaPainel()
        {
            List<Evento> listaEventos = EventoController.ListaEvento();
            List<EventoContato> listaIds = EventoContatoController.ListaContatosAtribuidos();

            foreach (Evento evento in listaEventos)
            {
                EventoControlView ec = new EventoControlView(painel as FlowLayoutPanel);
                ec.SalvaEvento(evento);
                painel.Controls.Add(ec);
                foreach (EventoContato contatoID in listaIds)
                {
                    if (contatoID.EventoId == evento.ID)
                        ec.SalvaContato(evento.ID, contatoID.ContatoId);
                }
            }
        }

        public string NomeEvento
        {
            get { return lblNome.Text.Trim(); }
            set { lblNome.Text = value; }
        }

        public string LocalEvento
        {
            get { return lblLocal.Text.Trim(); }
            set { lblLocal.Text = value; }
        }

        public string DescricaoEvento
        {
            get { return lblDescricao.Text.Trim(); }
            set { lblDescricao.Text = value; }
        }
        public DateTime DataInicio
        {
            get { return Convert.ToDateTime(lblDataInicio.Text); }
            set { lblDataInicio.Text = value.ToShortDateString(); }
        }

        public DateTime DataTermino
        {
            get { return Convert.ToDateTime(lblDataTermino.Text); }
            set { lblDataTermino.Text = value.ToShortDateString(); }
        }

        public string PeriodicidadeEvento
        {
            get { return lblPeriodicidade.Text.Trim(); }
            set { lblPeriodicidade.Text = value; }
        }

        public string StatusEvento
        {
            get { return lblStatus.Text.Trim(); }
            set { lblStatus.Text = value; }
        }

        public string? Contatos
        {
            get { return lblContato.Text.Trim(); }
            set { lblContato.Text = value; }
        }

        public string Foto
        {
            get { return lnkFoto.Tag.ToString()!; }
            set { lnkFoto.Tag = value; }
        }

        public void SalvaEvento(Evento e)
        {
            NomeEvento = e.NomeEvento;
            LocalEvento = e.LocalEvento;
            DescricaoEvento = e.DescricaoEvento;
            DataInicio = e.DataInicio;
            DataTermino = e.DataTermino;
            PeriodicidadeEvento = e.Periodicidade;
            StatusEvento = e.Status;
            lnkFoto.Tag = e.Foto;

            if (e.Status == "Concluido")
                lblNome.ForeColor = Color.Green;
            else if (e.Status == "Em Andamento")
                lblNome.ForeColor = Color.Blue;
            else
                lblNome.ForeColor = Color.Red;
        }

        public void SalvaContato(int idEvento, int idContato)
        {
            List<EventoContato> lista = EventoContatoController.retornaNomeContato(idEvento, idContato);

            foreach (EventoContato nomeContato in lista)
            {
                Contatos += nomeContato.NomeContato.ToString() + "; ";
            }
        }

        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FotoView formExibe = new FotoView(Foto);
                formExibe.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void toolStripMenuExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
              "Você realmente deseja excluir esse evento?", "SchedBrain",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                EventoController.ExcluiEvento(NomeEvento);
                painel.Controls.Clear();
                AtualizaPainel();
            }
        }

        private void toolStripMenuConcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
              "Você realmente deseja concluir esse evento?", "SchedBrain",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                EventoController.ConcluiEvento(NomeEvento);
                painel.Controls.Clear();
                AtualizaPainel();
            }
        }

        private void toolStripMenuIEditar_Click(object sender, EventArgs e)
        {
            EventoView f1 = (EventoView)FindForm();
            string eventoEditado = NomeEvento;
            f1.editaCampo(NomeEvento, LocalEvento, DescricaoEvento, DataInicio, DataTermino, PeriodicidadeEvento, StatusEvento, Foto, eventoEditado);
        }
    }
}
