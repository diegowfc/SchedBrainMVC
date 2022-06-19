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
    public partial class LembreteView : Form
    {
        private Tarefa tarefaAtual = null;
        private TarefaView formPai = null;

        public LembreteView(TarefaView f, Tarefa tarefa)
        {
            InitializeComponent();

            if (tarefa.Prioridade == "Alta")
            {
                lblTitulo.BackColor = Color.Red;
            }
            else if (tarefa.Prioridade == "Média")
            {
                lblTitulo.BackColor = Color.Orange;
            }
            else if (tarefa.Prioridade == "Baixa")
            {
                lblTitulo.BackColor = Color.Yellow;
            }

            lblTitulo.Text = tarefa.Titulo;
            lblDescricao.Text = tarefa.Descricao;

            tarefaAtual = tarefa;
            formPai = f;
        }
    }
}
