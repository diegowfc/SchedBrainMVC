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
    public partial class EventoView : Form
    {
        public EventoView()
        {
            InitializeComponent();
        }

        bool imagemAlterada = false;
        Evento eventoAlvo;

        private void EventoView_Load(object sender, EventArgs e)
        {
            cboPeriodicidade.SelectedIndex = 0;
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtNome.Focus();
            preenchePainel();
        }

        /// <summary>
        /// Limpa os campos de entrada após a inserção de um novo evento.
        /// </summary>
        public void resetaFormulario()
        {
            imagemAlterada = false;
            pcbAnexo.Image = global::SchedBrainMVC2.Properties.Resources.Foto;
            txtLocal.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            cboPeriodicidade.SelectedIndex = 0;
            dtpDataInicio.Value = DateTime.Now;
            dtpDataTermino.Value = DateTime.Now;
            rdoAndamento.Checked = false;
            rdoConcluido.Checked = false;
            txtNome.Focus();
        }

        /// <summary>
        /// Preenche o painel com os eventos previamente cadastrados
        /// </summary>
        public void preenchePainel()
        {
            List<Evento> listaEventos = EventoController.ListaEvento();
            flowLayoutPanel1.Controls.Clear();

            foreach(Evento evento in listaEventos)
            {
                EventoControlView ec = new EventoControlView(flowLayoutPanel1);
                ec.SalvaEvento(evento);
                flowLayoutPanel1.Controls.Add(ec);
            }
        }

        /// <summary>
        /// Preenche os campos de inserção para que o usuário possa editar alguma informação
        /// </summary>
        /// <param name="_nomeEvento"></param>
        /// <param name="_localEvento"></param>
        /// <param name="descricao"></param>
        /// <param name="inicio"></param>
        /// <param name="termino"></param>
        /// <param name="periodicidade"></param>
        /// <param name="status"></param>
        /// <param name="foto"></param>
        public void editaCampo(string nomeEvento, string localEvento, string descricao, DateTime inicio, DateTime termino, string periodicidade, string status, string foto, string eventoEditado)
        {
            eventoAlvo = EventoController.retornaEvento(eventoEditado);

            imagemAlterada = true;
            rdoCancelado.Visible = true;
            pcbAnexo.Tag = foto.ToString();

            try
            {
                if (foto != "")
                    pcbAnexo.Image = new Bitmap(foto);
            }
            catch (Exception)
            {
                pcbAnexo.Image = Properties.Resources.Foto;
                pcbAnexo.Image.Tag = "";
            }

            txtNome.Text = nomeEvento;
            txtLocal.Text = localEvento;
            txtDescricao.Text = descricao;
            dtpDataInicio.Value = inicio;
            dtpDataTermino.Value = termino;
            cboPeriodicidade.Text = periodicidade.ToString();
            if (status == "Concluido")
                rdoConcluido.Checked = true;
            else if (status == "Em Andamento")
                rdoAndamento.Checked = true;
            else
                rdoCancelado.Checked = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erros = false;
            string status, contatos = "";
            rdoCancelado.Visible = false;

            pcbAnexo.WaitOnLoad = imagemAlterada;

            if (txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, "Campo deve ser preenchido!");
                erros = true;
            }

            if (txtLocal.Text.Trim() == "")
            {
                errorProvider1.SetError(txtLocal, "Campo deve ser preenchido!");
                erros = true;
            }

            if (txtDescricao.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDescricao, "Campo deve ser preenchido!");
                erros = true;
            }

            if (dtpDataInicio.Value.Date > dtpDataTermino.Value.Date)
            {
                errorProvider1.SetError(dtpDataInicio, "Data início não pode ser maior que Data término!");
                erros = true;
            }

            if (rdoAndamento.Checked == false && rdoConcluido.Checked == false && rdoCancelado.Checked == false)
            {
                errorProvider1.SetError(rdoAndamento, "Campo deve ser preenchido!");
                erros = true;
            }

            if (cboPeriodicidade.SelectedIndex == 0)
            {
                errorProvider1.SetError(cboPeriodicidade, "Campo deve ser preenchido!");
                erros = true;
            }

            if (imagemAlterada == false)
            {
                errorProvider1.SetError(pcbAnexo, "Escolha uma foto!");
                erros = true;
            }

            if (rdoAndamento.Checked)
                status = "Em Andamento";
            else if (rdoConcluido.Checked)
                status = "Concluido";
            else
                status = "Cancelado";

            if (erros == false)
            {
                Evento evento = new Evento();

                if (eventoAlvo == null)
                {
                    evento.NomeEvento = txtNome.Text.Trim();
                    evento.LocalEvento = txtLocal.Text.Trim();
                    evento.DescricaoEvento = txtDescricao.Text.Trim();
                    evento.DataInicio = dtpDataInicio.Value.Date;
                    evento.DataTermino = dtpDataTermino.Value.Date;
                    evento.Periodicidade = cboPeriodicidade.Text.Trim();
                    evento.Contato = lstContatos.Text.Trim();
                    evento.Status = status;
                    evento.Foto = pcbAnexo.Tag.ToString();
                }
                else
                {
                    eventoAlvo.NomeEvento = txtNome.Text.Trim();
                    eventoAlvo.LocalEvento = txtLocal.Text.Trim();
                    eventoAlvo.DescricaoEvento = txtDescricao.Text.Trim();
                    eventoAlvo.DataInicio = dtpDataInicio.Value.Date;
                    eventoAlvo.DataTermino = dtpDataTermino.Value.Date;
                    eventoAlvo.Periodicidade = cboPeriodicidade.Text.Trim();
                    eventoAlvo.Contato = lstContatos.Text.Trim();
                    eventoAlvo.Status = status;
                    eventoAlvo.Foto = pcbAnexo.Tag.ToString();
                }

                if (eventoAlvo == null)
                    EventoController.InsereEvento(evento);
                else
                    EventoController.EditaEvento(eventoAlvo);

                preenchePainel();
                DialogResult dr = MessageBox.Show("Evento salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetaFormulario();
                eventoAlvo = null;
            }
        }

        private void pcbAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.BMP;)|*.jpg; *.jpeg; *.png; *.BMP;";
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Deseja limpar todos os campos?", "SchedBrain", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
                resetaFormulario();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            foreach (EventoControlView ec in flowLayoutPanel1.Controls)
            {
                if (!ec.LocalEvento.ToLower().Contains(txtPesquisar.Text.ToLower())
                    && !ec.StatusEvento.ToLower().Contains(txtPesquisar.Text.ToLower())
                    && !ec.DataInicio.ToString().Contains(txtPesquisar.Text)
                    && !ec.DataTermino.ToString().Contains(txtPesquisar.Text)
                    && !ec.Contatos.ToString().Contains(txtPesquisar.Text)
                    && !ec.NomeEvento.ToString().Contains(txtPesquisar.Text)
                    )
                    ec.Visible = false;
                else
                    ec.Visible = true;
            }
        }
    }
}
