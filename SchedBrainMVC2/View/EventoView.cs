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

        private void EventoView_Load(object sender, EventArgs e)
        {
            cboPeriodicidade.SelectedIndex = 0;
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtNome.Focus();
        }

        bool imagemAlterada = false;

        /// <summary>
        /// Limpa os campos de entrada após a inserção de um novo evento.
        /// </summary>
        public void limpaCampo()
        {
            imagemAlterada = false;
            //pcbAnexo.Image = global::SchedBrain.Properties.Resources.Foto;
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

        public void editaCampo(string _nomeEvento, string _localEvento, string descricao, DateTime inicio, DateTime termino, string periodicidade, string status, string foto)
        {

            //eventoAlvo = eventos[_nomeEvento].Nome;
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

            txtNome.Text = _nomeEvento;
            txtLocal.Text = _localEvento;
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
            bool erros = false, itemRepetido = false;
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
                Evento evento = new Evento(txtNome.Text, txtLocal.Text, txtDescricao.Text, dtpDataInicio.Value, dtpDataTermino.Value, cboPeriodicidade.Text, status, contatos, pcbAnexo.Tag.ToString()!);
                EventoController.Salvar(evento);

                if (itemRepetido == false)
                {
                    DialogResult dr = MessageBox.Show("Evento salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                        limpaCampo();
                }
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
        }
    }
}
