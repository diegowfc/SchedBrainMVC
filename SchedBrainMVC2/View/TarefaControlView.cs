using SchedBrainMVC2.Controller;
using SchedBrainMVC2.Model;
using SchedBrainMVC2.View;
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
    public partial class TarefaControlView : UserControl
    {
        public Tarefa tarefaAtual;

        Control painel = new Control();
        public TarefaControlView(FlowLayoutPanel flp)
        {
            InitializeComponent();
            painel = flp;
        }

        public void Atualizar()
        {
            List<Tarefa> listaTarefas = TarefaController.ListaTarefa();

            foreach (Tarefa tarefa in listaTarefas)
            {
                TarefaControlView t = new TarefaControlView(painel as FlowLayoutPanel);
                t.SalvaTarefa(tarefa);
                painel.Controls.Add(t);
            }
        }
        public string Titulo
        {
            get { return lbTarefaTitulo.Text.Trim(); }
            set { lbTarefaTitulo.Text = value; }
        }
        public string Descricao
        {
            get { return lbTarefaDesc.Text.Trim(); }
            set { lbTarefaDesc.Text = value; }
        }
        public string Prioridade
        {
            get { return lblTarefaPrioridade.Text.Trim(); }
            set { lblTarefaPrioridade.Text = value; }
        }

        public string Situacao
        {
            get { return lblTarefaSituacao.Text.Trim(); }
            set { lblTarefaSituacao.Text = value; }
        }

        public DateTime Horario
        {
            get { return Convert.ToDateTime(lblHorario.Text); }
            set { lblHorario.Text = value.ToShortDateString(); }
        }

        public string Contato
        {
            get { return lblContato.Text.Trim(); }
            set { lblContato.Text = value; }
        }

        public string Evento
        {
            get { return lblEvento.Text.Trim(); }
            set { lblEvento.Text = value; }
        }

        public string Anexo
        {
            get { return lnkFoto.Tag.ToString()!; }
            set { lnkFoto.Tag = value; }
        }

        public void SalvaTarefa(Tarefa t)
        {
            Titulo = t.Titulo;
            Descricao = t.Descricao;
            Prioridade = t.Prioridade;
            Situacao = t.Situacao;
            Horario = t.DataMaximaConclusao.Value;
            Contato = ContatoController.retornaApelidoContato(t.ContatoId);
            Evento = EventoController.retornaNomeEvento(t.EventoId);
            Anexo = t.Anexos;

            if (t.Prioridade == "Baixa")
                lblTarefaPrioridade.BackColor = Color.Yellow;
            else if (t.Prioridade == "Média")
                lblTarefaPrioridade.BackColor = Color.Orange;
            else
                lblTarefaPrioridade.BackColor = Color.Red;

            if (t.Situacao == "Concluído")
                lblTarefaSituacao.BackColor = Color.LightGreen;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarefaView f1 = (TarefaView)FindForm();

            string tarefaEditada = Titulo;
            f1.editaCampo(Titulo, Descricao, Horario, Prioridade, Anexo, tarefaEditada, ContextMenuStrip);
        }

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
              "Realmente deseja concluir essa Tarefa?", "SchedBrain",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                TarefaController.ConcluiTarefa(Titulo);
                painel.Controls.Clear();
                lblTarefaSituacao.BackColor = Color.Green;
                Atualizar();
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Você realmente deseja excluir a Tarefa?", "SchedBrain", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                TarefaController.ExcluiTarefa(Titulo);
                painel.Controls.Clear();
                Atualizar();
            }
        }

        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FotoView formExibe = new FotoView(Anexo);
                formExibe.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}