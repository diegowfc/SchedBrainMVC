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
    public partial class TarefaView : Form
    {
        List<Tarefa> listaTarefas = new List<Tarefa>();
        bool imagemAlterada = false;

        public TarefaView()
        {
            InitializeComponent();
        }

        private void TarefaView_Load(object sender, EventArgs e)
        {
            Atualizar();
            cboPrioridade.SelectedIndex = 0;
            cboContatos.SelectedIndex = 0;
            cboEventos.SelectedIndex = 0;
            preencheContatoEvento();
        }

        public void Atualizar()
        {
            List<Tarefa> listaTarefas = TarefaController.ListaTarefa();

            foreach (Tarefa tarefa in listaTarefas)
            {
                TarefaControlView t = new TarefaControlView(flpanel as FlowLayoutPanel);
                t.SalvaTarefa(tarefa);
                flpanel.Controls.Add(t);
            }
        }

        public void preencheContatoEvento()
        {
            foreach(Contato contato in ContatoController.ListaContatos())
                cboContatos.Items.Add(contato.Apelido);

            foreach (Evento evento in EventoController.ListaEvento())
                cboEventos.Items.Add(evento.NomeEvento);
        }

        public void limpaTarefa()
        {
            imagemAlterada = false;
            txtTarefaTitulo.Text = String.Empty;
            txtTarefaDesc.Text = String.Empty;
            dtpTarefaDate.Value = DateTime.Now;
            pcbAnexo.Image = Properties.Resources.AnexoTarefa;
            rdLembreteSim.Checked = false;
            rdLembreteNao.Checked = false;
            cboPrioridade.SelectedIndex = 0;
            cboContatos.SelectedIndex = 0;
            cboEventos.SelectedIndex = 0;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erros = false, sucesso = false;
            DialogResult dr = new DialogResult();

            if (txtTarefaTitulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTarefaTitulo, "Campo deve ser preenchido!");
                erros = true;
            }

            if (dtpTarefaDate.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpTarefaDate, "A data de conclusão não pode ser menor que agora!");
                erros = true;
            }

            if (cboPrioridade.SelectedIndex == 0)
            {
                errorProvider1.SetError(cboPrioridade, "Selecione a Prioridade!");
                erros = true;
            }

            if (imagemAlterada == false)
            {
                errorProvider1.SetError(pcbAnexo, "Selecione uma Imagem!");
                erros = true;
            }

            if (rdLembreteSim.Checked == false && rdLembreteNao.Checked == false)
            {
                errorProvider1.SetError(groupBox1, "Seleciona uma opção!");
                erros = true;
            }

            if (erros == false)
            {
                Tarefa t = new Tarefa();
                t.Titulo = txtTarefaTitulo.Text;
                t.Descricao = txtTarefaDesc.Text;
                t.Prioridade = cboPrioridade.Text;
                t.Anexos = pcbAnexo.Tag.ToString();
                t.Situacao = "Pendente";
                t.DataMaximaConclusao = new DateTime(dtpTarefaDate.Value.Year,
                    dtpTarefaDate.Value.Month, dtpTarefaDate.Value.Day,
                    dtpTarefaDate.Value.Hour, dtpTarefaDate.Value.Minute, 0);
                t.DataCriacao = DateTime.Now;

                if(cboContatos.SelectedIndex != 0)
                {
                    t.ContatoId = ContatoController.retornaContato(cboContatos.SelectedItem.ToString()).ID;
                }

                if (cboEventos.SelectedIndex != 0)
                {
                    t.EventoId = EventoController.retornaEvento(cboEventos.SelectedItem.ToString()).ID;
                }

                if (rdLembreteSim.Checked)
                {
                    t.Lembrete = true;
                }
                else if (rdLembreteNao.Checked)
                {
                    t.Lembrete = false;
                }
                timer1.Start();

                TarefaControlView tf = new TarefaControlView(flpanel);
                tf.SalvaTarefa(t);
                flpanel.Controls.Add(tf);

                try
                {
                    TarefaController.InsereTarefa(t);
                    sucesso = true;
                }
                catch { }

                if (sucesso)
                {
                    listaTarefas.Add(t);

                    MessageBox.Show("Tarefa salva com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTarefa();
                }
                else MessageBox.Show("Falha na inserção", "SchedBrain", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivos(*.jpg; *.jpeg; *.png; *.BMP;)|*.jpg; *.jpeg; *.png; *.BMP;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcbAnexo.Image = new Bitmap(open.FileName);
                    imagemAlterada = true;
                    pcbAnexo.Tag = open.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível carregar a foto", "SchedBrain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            foreach (TarefaControlView t in flpanel.Controls)
            {
                if (!t.Titulo.ToLower().Contains(txtPesquisar.Text.ToLower())
                    && !t.Descricao.ToLower().Contains(txtPesquisar.Text.ToLower())
                    &&!t.Horario.ToString().Contains(txtPesquisar.Text)
                    && !t.Prioridade.ToLower().Contains(txtPesquisar.Text.ToLower())
                    && !t.Situacao.ToLower().Contains(txtPesquisar.Text.ToLower())
                    )
                    t.Visible = false;
                else
                    t.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime agora = new DateTime(now.Year,
                now.Month, now.Day, now.Hour,
                now.Minute, 0);

            for (int tarefa = 0; tarefa < listaTarefas.Count; tarefa++)
            {
                if (listaTarefas[tarefa].Lembrete == true)
                {
                    //Tarefa Aviso
                    if (agora.AddDays(1) == listaTarefas[tarefa].DataMaximaConclusao)
                    {
                        listaTarefas[tarefa].Lembrete = false;
                        LembreteView lv = new LembreteView(this, listaTarefas[tarefa]);
                        lv.Show();
                    }

                    //Tarefa Expirou
                    if (agora == listaTarefas[tarefa].DataMaximaConclusao)
                    {
                        listaTarefas[tarefa].Lembrete = false;
                        LembreteView lv = new LembreteView(this, listaTarefas[tarefa]);
                        lv.Show();
                    }
                }
            }
        }
    }
}
