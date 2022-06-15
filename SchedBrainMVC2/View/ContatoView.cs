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
    public partial class ContatoView : Form
    {
        public ContatoView()
        {
            InitializeComponent();
        }

        bool contatoEditado = false;
        Contato contatoAlvo;

        private void ContatoView_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            preenchePainel();
        }

        /// <summary>
        /// Limpa os campos de entrada após a inserção de um novo evento.
        /// </summary>
        public void resetaFormulario()
        {
            pcbAnexo.Image = global::SchedBrainMVC2.Properties.Resources.Foto;
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtApelido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            dtpDataNascimento.Value = DateTime.Now;
            rdoPessoal.Checked = false;
            rdoProfissional.Checked = false;
            chkFavorito.Checked = false;
            btnExcluir.Visible = false;
            txtNome.Focus();
            txtEditar.Text = string.Empty;
            txtPesquisar.Text = string.Empty;
            
            if(contatoEditado == false)
            {
                rdoPessoal.Enabled = true;
                rdoProfissional.Enabled = true;
            }
        }

        /// <summary>
        /// Preenche os campos com as informações de um determinado contato, possibilitando a edição.
        /// </summary>
        /// <param name="contato"></param>
        public void editaContato(Contato contatoAlvo)
        {
            try
            {
                if (contatoAlvo.Imagem != "")
                {
                    pcbAnexo.Tag = contatoAlvo.Imagem;
                    pcbAnexo.Image = new Bitmap(contatoAlvo.Imagem);
                }

                txtNome.Text = contatoAlvo.Nome;
                txtSobrenome.Text = contatoAlvo.Sobrenome;
                txtApelido.Text = contatoAlvo.Apelido;
                txtEmail.Text = contatoAlvo.Email;
                txtTelefone.Text = contatoAlvo.Telefone;
                dtpDataNascimento.Value = contatoAlvo.Nascimento;
                if (contatoAlvo.Favorito == true)
                    chkFavorito.Checked = true;
                if (contatoAlvo.Tipo == "Profissional")
                    rdoProfissional.Checked = true;
                else
                    rdoPessoal.Checked = true;

                rdoPessoal.Enabled = false;
                rdoProfissional.Enabled = false;
            }
            catch (Exception)
            {
                pcbAnexo.Image = Properties.Resources.Foto;
                pcbAnexo.Image.Tag = "";
            }
        }

        /// <summary>
        /// Preenche o painel com os eventos previamente cadastrados
        /// </summary>
        public void preenchePainel()
        {
            List<Contato> listaContatos = ContatoController.ListaContatos();
            flpContatos.Controls.Clear();

            foreach (Contato contato in listaContatos)
            {
                ContatoControlView cc = new ContatoControlView(flpContatos);
                cc.SalvaContato(contato);
                flpContatos.Controls.Add(cc);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            errorProviderContato.Clear();
            bool erros = false, favorito = false;
            string tipo = "";
            DateTime dataLimite = new DateTime(1910, 12, 31);

            if (txtNome.Text.Trim() == "")
            {
                errorProviderContato.SetError(txtNome, "Campo deve ser preenchido!");
                erros = true;
            }

            if (txtSobrenome.Text.Trim() == "")
            {
                errorProviderContato.SetError(txtSobrenome, "Campo deve ser preenchido!");
                erros = true;
            }

            if (txtApelido.Text.Trim() == "")
            {
                errorProviderContato.SetError(txtApelido, "Campo deve ser preenchido!");
                erros = true;
            }

            if (txtEmail.Text.Trim() == "")
            {
                errorProviderContato.SetError(txtEmail, "Campo deve ser preenchido!");
                erros = true;
            }

            if (txtTelefone.Text.Trim() == "")
            {
                errorProviderContato.SetError(txtTelefone, "Campo deve ser preenchido!");
                erros = true;
            }

            if (dtpDataNascimento.Value.Date < dataLimite.Date)
            {
                errorProviderContato.SetError(dtpDataNascimento, "Data inválida");
                erros = true;
            }

            if (rdoPessoal.Checked == false && rdoProfissional.Checked == false && rdoPessoal.Enabled == true && rdoProfissional.Enabled == true)
            {
                errorProviderContato.SetError(rdoProfissional, "Escolha um tipo: Profissional ou Pessoal!");
                erros = true;
            }

            if (chkFavorito.Checked == true)
                favorito = true;

            if (rdoPessoal.Checked)
                tipo = "Pessoal";
            else if (rdoProfissional.Checked)
                tipo = "Profissional";

            if (erros == false)
            {
                Contato contato = new Contato();

                if (contatoAlvo == null)
                {
                    contato.Nome = txtNome.Text.Trim();
                    contato.Sobrenome = txtSobrenome.Text.Trim();
                    contato.Apelido = txtApelido.Text.Trim();
                    contato.Telefone = txtTelefone.Text.Trim();
                    contato.Email = txtEmail.Text.Trim();
                    contato.Nascimento = dtpDataNascimento.Value.Date;
                    contato.Tipo = tipo;
                    contato.Favorito = favorito;
                    contato.Imagem = pcbAnexo.Tag.ToString();
                }
                else
                {
                    contatoAlvo.Nome = txtNome.Text.Trim();
                    contatoAlvo.Sobrenome = txtSobrenome.Text.Trim();
                    contatoAlvo.Apelido = txtApelido.Text.Trim();
                    contatoAlvo.Telefone = txtTelefone.Text.Trim();
                    contatoAlvo.Email = txtEmail.Text.Trim();
                    contatoAlvo.Nascimento = dtpDataNascimento.Value.Date;
                    contatoAlvo.Tipo = tipo;
                    contato.Favorito = favorito;
                    contatoAlvo.Imagem = pcbAnexo.Tag.ToString();
                }

                if(contatoAlvo == null)
                    ContatoController.InsereContato(contato);
                else
                    ContatoController.EditaContato(contatoAlvo);

                preenchePainel();
                DialogResult dr = MessageBox.Show("Contato salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contatoEditado = false;
                resetaFormulario();
                contatoAlvo = null;
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
                    pcbAnexo.Tag = open.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível carregar a foto", "SchedBrain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string apelido = txtEditar.Text.Trim();
            contatoAlvo = ContatoController.retornaContato(apelido);

            if (contatoAlvo != null)
            {
                contatoEditado = true;
                btnExcluir.Visible = true;
                editaContato(contatoAlvo);
            }
            else
                MessageBox.Show("O apelido informado não existe no sistema!", "SchedBrain", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string apelido = txtEditar.Text.Trim();
            DialogResult dr = MessageBox.Show(
              "Você realmente deseja excluir esse contato?", "SchedBrain",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                contatoAlvo = null;
                flpContatos.Controls.Clear();
                ContatoController.ExcluiContato(apelido);
                contatoEditado = false;
                resetaFormulario();
                preenchePainel();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            foreach (ContatoControlView cc in flpContatos.Controls)
            {

                if (chkPesquisa.Checked == true && !cc.Favorito == true) cc.Visible = false;
                else if (chkPesquisa.Checked == false)
                {

                    if (!cc.Telefone.ToLower().Contains(txtPesquisar.Text.ToLower())
                        && !cc.Email.ToLower().Contains(txtPesquisar.Text.ToLower())
                        && !cc.DataNascimento.ToString().Contains(txtPesquisar.Text)
                        && !cc.Apelido.ToString().Contains(txtPesquisar.Text)
                        && !cc.Sobrenome.ToString().Contains(txtPesquisar.Text)
                        && !cc.Nome.ToString().Contains(txtPesquisar.Text)
                        && !cc.Tipo.ToString().Contains(txtPesquisar.Text)
                        )
                        cc.Visible = false;
                    else
                        cc.Visible = true;
                }
            }
        }
    }
}
