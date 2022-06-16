namespace SchedBrainMVC2.View
{
    partial class EventoView
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
            this.rdoCancelado = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pcbAnexo = new System.Windows.Forms.PictureBox();
            this.rdoAndamento = new System.Windows.Forms.RadioButton();
            this.rdoConcluido = new System.Windows.Forms.RadioButton();
            this.cboPeriodicidade = new System.Windows.Forms.ComboBox();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstContatos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoCancelado
            // 
            this.rdoCancelado.AutoSize = true;
            this.rdoCancelado.Location = new System.Drawing.Point(210, 473);
            this.rdoCancelado.Name = "rdoCancelado";
            this.rdoCancelado.Size = new System.Drawing.Size(81, 19);
            this.rdoCancelado.TabIndex = 9;
            this.rdoCancelado.TabStop = true;
            this.rdoCancelado.Text = "Cancelado";
            this.rdoCancelado.UseVisualStyleBackColor = true;
            this.rdoCancelado.Visible = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(325, 8);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PlaceholderText = "Pesquise por Nome, Local, Datas, Status e Contatos";
            this.txtPesquisar.Size = new System.Drawing.Size(303, 23);
            this.txtPesquisar.TabIndex = 55;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(712, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Para executar uma ação, clique com o botão direito sob o evento";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 186);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderText = "Descrição do evento";
            this.txtDescricao.Size = new System.Drawing.Size(281, 49);
            this.txtDescricao.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(325, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(698, 483);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Location = new System.Drawing.Point(10, 300);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(281, 23);
            this.dtpDataTermino.TabIndex = 4;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(10, 256);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(281, 23);
            this.dtpDataInicio.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(216, 498);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pcbAnexo
            // 
            this.pcbAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAnexo.Image = global::SchedBrainMVC2.Properties.Resources.Foto;
            this.pcbAnexo.Location = new System.Drawing.Point(10, 9);
            this.pcbAnexo.Name = "pcbAnexo";
            this.pcbAnexo.Size = new System.Drawing.Size(281, 113);
            this.pcbAnexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnexo.TabIndex = 52;
            this.pcbAnexo.TabStop = false;
            this.pcbAnexo.Click += new System.EventHandler(this.pcbAnexo_Click);
            // 
            // rdoAndamento
            // 
            this.rdoAndamento.AutoSize = true;
            this.rdoAndamento.Location = new System.Drawing.Point(96, 473);
            this.rdoAndamento.Name = "rdoAndamento";
            this.rdoAndamento.Size = new System.Drawing.Size(106, 19);
            this.rdoAndamento.TabIndex = 8;
            this.rdoAndamento.TabStop = true;
            this.rdoAndamento.Text = "Em andamento";
            this.rdoAndamento.UseVisualStyleBackColor = true;
            // 
            // rdoConcluido
            // 
            this.rdoConcluido.AutoSize = true;
            this.rdoConcluido.Location = new System.Drawing.Point(10, 473);
            this.rdoConcluido.Name = "rdoConcluido";
            this.rdoConcluido.Size = new System.Drawing.Size(80, 19);
            this.rdoConcluido.TabIndex = 7;
            this.rdoConcluido.TabStop = true;
            this.rdoConcluido.Text = "Concluído";
            this.rdoConcluido.UseVisualStyleBackColor = true;
            // 
            // cboPeriodicidade
            // 
            this.cboPeriodicidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodicidade.Items.AddRange(new object[] {
            "<<PERIODICIDADE>>",
            "Todos os dias",
            "A cada semana",
            "A cada 2 semanas",
            "A cada mês",
            "A cada ano",
            "Uma vez"});
            this.cboPeriodicidade.Location = new System.Drawing.Point(10, 329);
            this.cboPeriodicidade.Name = "cboPeriodicidade";
            this.cboPeriodicidade.Size = new System.Drawing.Size(281, 23);
            this.cboPeriodicidade.TabIndex = 5;
            this.cboPeriodicidade.Tag = "1";
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Location = new System.Drawing.Point(10, 282);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(92, 15);
            this.lblDataTermino.TabIndex = 51;
            this.lblDataTermino.Text = "Data de término";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Data de início";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(10, 157);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PlaceholderText = "Local do evento";
            this.txtLocal.Size = new System.Drawing.Size(281, 23);
            this.txtLocal.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome do evento";
            this.txtNome.Size = new System.Drawing.Size(281, 23);
            this.txtNome.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(135, 498);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstContatos
            // 
            this.lstContatos.FormattingEnabled = true;
            this.lstContatos.ItemHeight = 15;
            this.lstContatos.Location = new System.Drawing.Point(12, 358);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstContatos.Size = new System.Drawing.Size(279, 109);
            this.lstContatos.TabIndex = 56;
            // 
            // EventoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 534);
            this.Controls.Add(this.lstContatos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rdoCancelado);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtpDataTermino);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pcbAnexo);
            this.Controls.Add(this.rdoAndamento);
            this.Controls.Add(this.rdoConcluido);
            this.Controls.Add(this.cboPeriodicidade);
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.Name = "EventoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de evento";
            this.Load += new System.EventHandler(this.EventoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoCancelado;
        private ListBox lstContatos;
        private TextBox txtPesquisar;
        private Label label2;
        private TextBox txtDescricao;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpDataTermino;
        private DateTimePicker dtpDataInicio;
        private Button btnCadastrar;
        private PictureBox pcbAnexo;
        private RadioButton rdoAndamento;
        private RadioButton rdoConcluido;
        private ComboBox cboPeriodicidade;
        private Label lblDataTermino;
        private Label label1;
        private TextBox txtLocal;
        private TextBox txtNome;
        private ErrorProvider errorProvider1;
        private Button btnLimpar;
    }
}