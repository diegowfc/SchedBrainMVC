namespace SchedBrainMVC2.View
{
    partial class TarefaControlView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTarefaPrioridade = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTarefaSituacao = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lbTarefaDesc = new System.Windows.Forms.Label();
            this.lbTarefaTitulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lnkFoto = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTarefaPrioridade
            // 
            this.lblTarefaPrioridade.AutoSize = true;
            this.lblTarefaPrioridade.BackColor = System.Drawing.Color.Red;
            this.lblTarefaPrioridade.Location = new System.Drawing.Point(3, 205);
            this.lblTarefaPrioridade.Name = "lblTarefaPrioridade";
            this.lblTarefaPrioridade.Size = new System.Drawing.Size(61, 15);
            this.lblTarefaPrioridade.TabIndex = 2;
            this.lblTarefaPrioridade.Text = "Prioridade";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.concluirToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // lblTarefaSituacao
            // 
            this.lblTarefaSituacao.AutoSize = true;
            this.lblTarefaSituacao.Location = new System.Drawing.Point(234, 205);
            this.lblTarefaSituacao.Name = "lblTarefaSituacao";
            this.lblTarefaSituacao.Size = new System.Drawing.Size(57, 15);
            this.lblTarefaSituacao.TabIndex = 4;
            this.lblTarefaSituacao.Text = "Pendente";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(128, 205);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(38, 15);
            this.lblHorario.TabIndex = 5;
            this.lblHorario.Text = "label1";
            // 
            // lbTarefaDesc
            // 
            this.lbTarefaDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTarefaDesc.AutoSize = true;
            this.lbTarefaDesc.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTarefaDesc.Location = new System.Drawing.Point(3, 0);
            this.lbTarefaDesc.Name = "lbTarefaDesc";
            this.lbTarefaDesc.Size = new System.Drawing.Size(67, 18);
            this.lbTarefaDesc.TabIndex = 1;
            this.lbTarefaDesc.Text = "Descrição";
            // 
            // lbTarefaTitulo
            // 
            this.lbTarefaTitulo.AutoSize = true;
            this.lbTarefaTitulo.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTarefaTitulo.Location = new System.Drawing.Point(109, 0);
            this.lbTarefaTitulo.Name = "lbTarefaTitulo";
            this.lbTarefaTitulo.Size = new System.Drawing.Size(80, 33);
            this.lbTarefaTitulo.TabIndex = 0;
            this.lbTarefaTitulo.Text = "Título";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.lbTarefaDesc);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 110);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evento:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(62, 41);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(38, 15);
            this.lblContato.TabIndex = 9;
            this.lblContato.Text = "label3";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(62, 65);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(38, 15);
            this.lblEvento.TabIndex = 10;
            this.lblEvento.Text = "label3";
            // 
            // lnkFoto
            // 
            this.lnkFoto.AutoSize = true;
            this.lnkFoto.Location = new System.Drawing.Point(3, 0);
            this.lnkFoto.Name = "lnkFoto";
            this.lnkFoto.Size = new System.Drawing.Size(58, 15);
            this.lnkFoto.TabIndex = 11;
            this.lnkFoto.TabStop = true;
            this.lnkFoto.Text = "Ver anexo";
            this.lnkFoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFoto_LinkClicked);
            // 
            // TarefaControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lnkFoto);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTarefaTitulo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTarefaSituacao);
            this.Controls.Add(this.lblTarefaPrioridade);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TarefaControlView";
            this.Size = new System.Drawing.Size(294, 220);
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTarefaPrioridade;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private Label lblTarefaSituacao;
        private ToolStripMenuItem concluirToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private Label lblHorario;
        private Label lbTarefaDesc;
        private Label lbTarefaTitulo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label lblContato;
        private Label lblEvento;
        private LinkLabel lnkFoto;
    }
}