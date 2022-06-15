namespace SchedBrainMVC2.View
{
    partial class ContatoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.flpContatos = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.pcbAnexo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rdoProfissional = new System.Windows.Forms.RadioButton();
            this.rdoPessoal = new System.Windows.Forms.RadioButton();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.chkFavorito = new System.Windows.Forms.CheckBox();
            this.errorProviderContato = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.chkPesquisa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(324, 11);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PlaceholderText = "Pesquise para filtrar um contato através de suas informações";
            this.txtPesquisar.Size = new System.Drawing.Size(329, 23);
            this.txtPesquisar.TabIndex = 68;
            // 
            // flpContatos
            // 
            this.flpContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpContatos.AutoScroll = true;
            this.flpContatos.Location = new System.Drawing.Point(324, 70);
            this.flpContatos.Name = "flpContatos";
            this.flpContatos.Size = new System.Drawing.Size(626, 369);
            this.flpContatos.TabIndex = 66;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(9, 291);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(278, 23);
            this.dtpDataNascimento.TabIndex = 5;
            // 
            // pcbAnexo
            // 
            this.pcbAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAnexo.Image = global::SchedBrainMVC2.Properties.Resources.Foto;
            this.pcbAnexo.Location = new System.Drawing.Point(9, 12);
            this.pcbAnexo.Name = "pcbAnexo";
            this.pcbAnexo.Size = new System.Drawing.Size(278, 113);
            this.pcbAnexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnexo.TabIndex = 65;
            this.pcbAnexo.TabStop = false;
            this.pcbAnexo.Click += new System.EventHandler(this.pcbAnexo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Data de nascimento";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(9, 160);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.PlaceholderText = "Sobrenome do contato";
            this.txtSobrenome.Size = new System.Drawing.Size(278, 23);
            this.txtSobrenome.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome do contato";
            this.txtNome.Size = new System.Drawing.Size(278, 23);
            this.txtNome.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(131, 345);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(212, 345);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rdoProfissional
            // 
            this.rdoProfissional.AutoSize = true;
            this.rdoProfissional.Location = new System.Drawing.Point(201, 320);
            this.rdoProfissional.Name = "rdoProfissional";
            this.rdoProfissional.Size = new System.Drawing.Size(86, 19);
            this.rdoProfissional.TabIndex = 7;
            this.rdoProfissional.TabStop = true;
            this.rdoProfissional.Text = "Profissional";
            this.rdoProfissional.UseVisualStyleBackColor = true;
            // 
            // rdoPessoal
            // 
            this.rdoPessoal.AutoSize = true;
            this.rdoPessoal.Location = new System.Drawing.Point(131, 320);
            this.rdoPessoal.Name = "rdoPessoal";
            this.rdoPessoal.Size = new System.Drawing.Size(64, 19);
            this.rdoPessoal.TabIndex = 6;
            this.rdoPessoal.TabStop = true;
            this.rdoPessoal.Text = "Pessoal";
            this.rdoPessoal.UseVisualStyleBackColor = true;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(9, 189);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.PlaceholderText = "Apelido do contato";
            this.txtApelido.Size = new System.Drawing.Size(278, 23);
            this.txtApelido.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email do contato";
            this.txtEmail.Size = new System.Drawing.Size(278, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(9, 247);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PlaceholderText = "Telefone do contato";
            this.txtTelefone.Size = new System.Drawing.Size(278, 23);
            this.txtTelefone.TabIndex = 4;
            // 
            // chkFavorito
            // 
            this.chkFavorito.AutoSize = true;
            this.chkFavorito.Location = new System.Drawing.Point(9, 321);
            this.chkFavorito.Name = "chkFavorito";
            this.chkFavorito.Size = new System.Drawing.Size(116, 19);
            this.chkFavorito.TabIndex = 8;
            this.chkFavorito.Text = "Favoritar contato";
            this.chkFavorito.UseVisualStyleBackColor = true;
            // 
            // errorProviderContato
            // 
            this.errorProviderContato.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContato.ContainerControl = this;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(50, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(779, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(125, 23);
            this.btnPesquisar.TabIndex = 70;
            this.btnPesquisar.Text = "Pesquisar contatos";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(659, 41);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 23);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.Text = "Editar informações";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(324, 40);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.PlaceholderText = "Busque um contato pelo apelido para editá-lo ou excluí-lo";
            this.txtEditar.Size = new System.Drawing.Size(329, 23);
            this.txtEditar.TabIndex = 72;
            // 
            // chkPesquisa
            // 
            this.chkPesquisa.AutoSize = true;
            this.chkPesquisa.Location = new System.Drawing.Point(659, 13);
            this.chkPesquisa.Name = "chkPesquisa";
            this.chkPesquisa.Size = new System.Drawing.Size(114, 19);
            this.chkPesquisa.TabIndex = 73;
            this.chkPesquisa.Text = "Apenas favoritos";
            this.chkPesquisa.UseVisualStyleBackColor = true;
            // 
            // ContatoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 451);
            this.Controls.Add(this.chkPesquisa);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.chkFavorito);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rdoProfissional);
            this.Controls.Add(this.rdoPessoal);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.flpContatos);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.pcbAnexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.Name = "ContatoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.ContatoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPesquisar;
        private FlowLayoutPanel flpContatos;
        private DateTimePicker dtpDataNascimento;
        private PictureBox pcbAnexo;
        private Label label1;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Button btnLimpar;
        private Button btnCadastrar;
        private RadioButton rdoProfissional;
        private RadioButton rdoPessoal;
        private TextBox txtApelido;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private CheckBox chkFavorito;
        private ErrorProvider errorProviderContato;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private TextBox txtEditar;
        private CheckBox chkPesquisa;
    }
}