namespace SchedBrainMVC2.View
{
    partial class TarefaView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pcbAnexo = new System.Windows.Forms.PictureBox();
            this.txtTarefaTitulo = new System.Windows.Forms.TextBox();
            this.txtTarefaDesc = new System.Windows.Forms.TextBox();
            this.dtpTarefaDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPrioridade = new System.Windows.Forms.ComboBox();
            this.rdLembreteSim = new System.Windows.Forms.RadioButton();
            this.rdLembreteNao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.flpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cboContatos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEventos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnexo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de Conclusão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Anexo";
            // 
            // pcbAnexo
            // 
            this.pcbAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAnexo.Image = global::SchedBrainMVC2.Properties.Resources.AnexoTarefa;
            this.pcbAnexo.Location = new System.Drawing.Point(6, 404);
            this.pcbAnexo.Name = "pcbAnexo";
            this.pcbAnexo.Size = new System.Drawing.Size(100, 100);
            this.pcbAnexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnexo.TabIndex = 2;
            this.pcbAnexo.TabStop = false;
            this.pcbAnexo.Click += new System.EventHandler(this.pcbAnexo_Click);
            // 
            // txtTarefaTitulo
            // 
            this.txtTarefaTitulo.Location = new System.Drawing.Point(6, 12);
            this.txtTarefaTitulo.MaxLength = 26;
            this.txtTarefaTitulo.Name = "txtTarefaTitulo";
            this.txtTarefaTitulo.PlaceholderText = "Título";
            this.txtTarefaTitulo.Size = new System.Drawing.Size(162, 23);
            this.txtTarefaTitulo.TabIndex = 0;
            // 
            // txtTarefaDesc
            // 
            this.txtTarefaDesc.Location = new System.Drawing.Point(6, 41);
            this.txtTarefaDesc.MaxLength = 2130;
            this.txtTarefaDesc.Multiline = true;
            this.txtTarefaDesc.Name = "txtTarefaDesc";
            this.txtTarefaDesc.PlaceholderText = "Descrição";
            this.txtTarefaDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTarefaDesc.Size = new System.Drawing.Size(162, 162);
            this.txtTarefaDesc.TabIndex = 1;
            // 
            // dtpTarefaDate
            // 
            this.dtpTarefaDate.CustomFormat = "yyyy/MM/dd\'  \'HH:mm";
            this.dtpTarefaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarefaDate.Location = new System.Drawing.Point(6, 224);
            this.dtpTarefaDate.Name = "dtpTarefaDate";
            this.dtpTarefaDate.Size = new System.Drawing.Size(162, 23);
            this.dtpTarefaDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prioridade";
            // 
            // cboPrioridade
            // 
            this.cboPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridade.FormattingEnabled = true;
            this.cboPrioridade.Items.AddRange(new object[] {
            "<Selecionar>",
            "Alta",
            "Média",
            "Baixa"});
            this.cboPrioridade.Location = new System.Drawing.Point(6, 268);
            this.cboPrioridade.Name = "cboPrioridade";
            this.cboPrioridade.Size = new System.Drawing.Size(162, 23);
            this.cboPrioridade.TabIndex = 3;
            // 
            // rdLembreteSim
            // 
            this.rdLembreteSim.AutoSize = true;
            this.rdLembreteSim.Location = new System.Drawing.Point(6, 22);
            this.rdLembreteSim.Name = "rdLembreteSim";
            this.rdLembreteSim.Size = new System.Drawing.Size(45, 19);
            this.rdLembreteSim.TabIndex = 6;
            this.rdLembreteSim.TabStop = true;
            this.rdLembreteSim.Text = "Sim";
            this.rdLembreteSim.UseVisualStyleBackColor = true;
            // 
            // rdLembreteNao
            // 
            this.rdLembreteNao.AutoSize = true;
            this.rdLembreteNao.Location = new System.Drawing.Point(109, 22);
            this.rdLembreteNao.Name = "rdLembreteNao";
            this.rdLembreteNao.Size = new System.Drawing.Size(47, 19);
            this.rdLembreteNao.TabIndex = 7;
            this.rdLembreteNao.TabStop = true;
            this.rdLembreteNao.Text = "Não";
            this.rdLembreteNao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLembreteSim);
            this.groupBox1.Controls.Add(this.rdLembreteNao);
            this.groupBox1.Location = new System.Drawing.Point(6, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 44);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deseja Criar um Lembrete?";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 567);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // flpanel
            // 
            this.flpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpanel.AutoScroll = true;
            this.flpanel.Location = new System.Drawing.Point(195, 58);
            this.flpanel.Name = "flpanel";
            this.flpanel.Size = new System.Drawing.Size(612, 538);
            this.flpanel.TabIndex = 7;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(195, 12);
            this.txtPesquisar.MaxLength = 2130;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PlaceholderText = "Pesquisar por título, descrição, período, situação ou prioridade";
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPesquisar.Size = new System.Drawing.Size(343, 23);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(481, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Para executar uma ação, clique com o botão direito sob uma tarefa";
            // 
            // cboContatos
            // 
            this.cboContatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContatos.FormattingEnabled = true;
            this.cboContatos.Items.AddRange(new object[] {
            "<Opcional>"});
            this.cboContatos.Location = new System.Drawing.Point(6, 312);
            this.cboContatos.Name = "cboContatos";
            this.cboContatos.Size = new System.Drawing.Size(162, 23);
            this.cboContatos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contatos";
            // 
            // cboEventos
            // 
            this.cboEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventos.FormattingEnabled = true;
            this.cboEventos.Items.AddRange(new object[] {
            "<Opcional>"});
            this.cboEventos.Location = new System.Drawing.Point(6, 356);
            this.cboEventos.Name = "cboEventos";
            this.cboEventos.Size = new System.Drawing.Size(162, 23);
            this.cboEventos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eventos";
            // 
            // TarefaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 609);
            this.Controls.Add(this.cboEventos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboContatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpanel);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPrioridade);
            this.Controls.Add(this.dtpTarefaDate);
            this.Controls.Add(this.txtTarefaDesc);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtTarefaTitulo);
            this.Controls.Add(this.pcbAnexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "TarefaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de tarefas";
            this.Load += new System.EventHandler(this.TarefaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnexo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private PictureBox pcbAnexo;
        private TextBox txtTarefaTitulo;
        private TextBox txtTarefaDesc;
        private DateTimePicker dtpTarefaDate;
        private Label label6;
        private ComboBox cboPrioridade;
        private RadioButton rdLembreteSim;
        private RadioButton rdLembreteNao;
        private GroupBox groupBox1;
        private Button btnCadastrar;
        private FlowLayoutPanel flpanel;
        private TextBox txtPesquisar;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private ComboBox cboEventos;
        private Label label2;
        private ComboBox cboContatos;
        private Label label1;
    }
}