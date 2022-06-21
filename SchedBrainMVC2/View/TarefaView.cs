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
        Tarefa tarefaAlvo;

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
            txtTarefaTitulo.Focus();
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
            foreach (Contato contato in ContatoController.ListaContatos())
                cboContatos.Items.Add(contato.Apelido);

            foreach (Evento evento in EventoController.ListaEvento())
                cboEventos.Items.Add(evento.NomeEvento);
        }

        public void preenchePainel()
        {
            List<Tarefa> listaTarefas = TarefaController.ListaTarefa();
            flpanel.Controls.Clear();

            foreach (Tarefa tarefa in listaTarefas)
            {
                TarefaControlView tf = new TarefaControlView(flpanel);
                tf.SalvaTarefa(tarefa);
                flpanel.Controls.Add(tf);
            }
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
            txtTarefaTitulo.Focus();
            tarefaAlvo = null;
        }

        public void editaCampo(string titulo, string descricao, DateTime datamaximaconclusao, string prioridade, string anexo, string tarefaEditada, ContextMenuStrip cms)
        {
            tarefaAlvo = TarefaController.retornaTarefa(tarefaEditada);
            rdLembreteNao.Visible = true;
            rdLembreteSim.Visible = true;
            imagemAlterada = true;
            pcbAnexo.Tag = anexo.ToString();

            cms.Enabled = false;

            try
            {
                if (anexo != "")
                    pcbAnexo.Image = new Bitmap(anexo);
            }
            catch (Exception)
            {
                pcbAnexo.Image = Properties.Resources.AnexoTarefa;
                pcbAnexo.Image.Tag = "";
            }

            txtTarefaTitulo.Text = titulo;
            txtTarefaDesc.Text = descricao;
            dtpTarefaDate.Value = datamaximaconclusao;
            cboPrioridade.Text = prioridade.ToString();

            if (tarefaAlvo.ContatoId != null)
                cboContatos.SelectedItem = ContatoController.retornaApelidoContato(tarefaAlvo.ContatoId);
            if (tarefaAlvo.EventoId != null)
                cboEventos.SelectedItem = EventoController.retornaNomeEvento(tarefaAlvo.EventoId);

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

                if (tarefaAlvo == null)
                {
                    t.Titulo = txtTarefaTitulo.Text;
                    t.Descricao = txtTarefaDesc.Text;
                    t.Prioridade = cboPrioridade.Text;
                    t.Anexos = pcbAnexo.Tag.ToString();
                    t.Situacao = "Pendente";
                    t.DataMaximaConclusao = new DateTime(dtpTarefaDate.Value.Year,
                        dtpTarefaDate.Value.Month, dtpTarefaDate.Value.Day,
                        dtpTarefaDate.Value.Hour, dtpTarefaDate.Value.Minute, 0);
                    t.DataCriacao = DateTime.Now;

                    if (cboContatos.SelectedIndex != 0) t.ContatoId = ContatoController.retornaContato(cboContatos.SelectedItem.ToString()).ID;
                    if (cboEventos.SelectedIndex != 0) t.EventoId = EventoController.retornaEvento(cboEventos.SelectedItem.ToString()).ID;
                    if (rdLembreteSim.Checked) t.Lembrete = true;
                    else if (rdLembreteNao.Checked) t.Lembrete = false;
                    timer1.Start();
                }
                else
                {
                    tarefaAlvo.Titulo = txtTarefaTitulo.Text.Trim();
                    tarefaAlvo.Descricao = txtTarefaDesc.Text.Trim();
                    tarefaAlvo.Prioridade = cboPrioridade.Text.Trim();
                    tarefaAlvo.Anexos = pcbAnexo.Tag.ToString();
                    tarefaAlvo.DataMaximaConclusao = new DateTime(dtpTarefaDate.Value.Year,
                        dtpTarefaDate.Value.Month, dtpTarefaDate.Value.Day,
                        dtpTarefaDate.Value.Hour, dtpTarefaDate.Value.Minute, 0);
                    tarefaAlvo.DataCriacao = DateTime.Now;

                    if (cboContatos.SelectedIndex != 0) tarefaAlvo.ContatoId = ContatoController.retornaContato(cboContatos.SelectedItem.ToString()).ID;
                    else if (cboContatos.SelectedIndex == 0) tarefaAlvo.ContatoId = null;

                    if (cboEventos.SelectedIndex != 0) tarefaAlvo.EventoId = EventoController.retornaEvento(cboEventos.SelectedItem.ToString()).ID;
                    else if (cboEventos.SelectedIndex == 0) tarefaAlvo.EventoId = null;
                    if (rdLembreteSim.Checked) tarefaAlvo.Lembrete = true;
                    if (rdLembreteSim.Checked) tarefaAlvo.Lembrete = true;
                    else if (rdLembreteNao.Checked) tarefaAlvo.Lembrete = false;

                    timer1.Start();
                }
                try
                {
                    if (tarefaAlvo == null)
                    {
                        TarefaController.InsereTarefa(t);
                        listaTarefas.Add(t);
                    }
                    else
                    {
                        TarefaController.EditaTarefa(tarefaAlvo);
                        listaTarefas.Add(tarefaAlvo);
                    }
                    sucesso = true;
                }
                catch { }

                if (sucesso)
                {
                    MessageBox.Show("Tarefa salva com sucesso!", "SchedBrain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTarefa();
                    preenchePainel();
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
                    && !t.Horario.ToString().Contains(txtPesquisar.Text)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Deseja limpar todos os campos?", "SchedBrain",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
                limpaTarefa();
        }
    }
}
