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
    public partial class ContatoControlView : UserControl
    {
        Control painel = new Control();

        public ContatoControlView(FlowLayoutPanel flp)
        {
            InitializeComponent();
            painel = flp;
        }

        /// <summary>
        /// Atualiza o painel após alguma ação do usuário
        /// </summary>
        public void AtualizaPainel()
        {
            List<Contato> listaContatos = ContatoController.ListaContatos();

            foreach (Contato contato in listaContatos)
            {
                ContatoControlView cc = new ContatoControlView(painel as FlowLayoutPanel);
                cc.SalvaContato(contato);
                painel.Controls.Add(cc);
            }
        }

        public string Nome
        {
            get { return lblNome.Text.Trim(); }
            set { lblNome.Text = value; }
        }

        public string Sobrenome
        {
            get { return lblSobrenome.Text.Trim(); }
            set { lblSobrenome.Text = value; }
        }

        public string Apelido
        {
            get { return lblApelido.Text.Trim(); }
            set { lblApelido.Text = value; }
        }
        public DateTime DataNascimento
        {
            get { return Convert.ToDateTime(lblDataNascimento.Text); }
            set { lblDataNascimento.Text = value.ToShortDateString(); }
        }

        public string Email
        {
            get { return lblEmail.Text.Trim(); }
            set { lblEmail.Text = value; }
        }

        public string Telefone
        {
            get { return lblTelefone.Text.Trim(); }
            set { lblTelefone.Text = value; }
        }

        public string Tipo
        {
            get { return lblTipo.Text.Trim(); }
            set { lblTipo.Text = value; }
        }

        public bool Favorito
        {
            get { return txtFavorito.Visible; }
            set { txtFavorito.Visible = value; }
        }

        public void SalvaContato(Contato contato)
        {
            Nome = contato.Nome;
            Sobrenome = contato.Sobrenome;
            Apelido = contato.Apelido;
            Email = contato.Email;
            Telefone = contato.Telefone;
            DataNascimento = contato.Nascimento;
            Tipo = contato.Tipo;

            if (contato.Favorito == true)
                txtFavorito.Visible = true;

            try
            {
                pcbFoto.Image = new Bitmap(contato.Imagem);
            }
            catch (Exception)
            {
                MessageBox.Show($"Foto do contato {contato.Nome} não foi encontrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
