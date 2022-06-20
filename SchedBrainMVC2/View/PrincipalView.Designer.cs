namespace SchedBrainMVC2.View
{
    partial class PrincipalView
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
            this.label1 = new System.Windows.Forms.Label();
            this.AcessaContato = new System.Windows.Forms.Button();
            this.AcessaEvento = new System.Windows.Forms.Button();
            this.AcessaTarefa = new System.Windows.Forms.Button();
            this.flpContatoPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEventoPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTarefaPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao SchedBrain!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcessaContato
            // 
            this.AcessaContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcessaContato.Location = new System.Drawing.Point(191, 100);
            this.AcessaContato.Name = "AcessaContato";
            this.AcessaContato.Size = new System.Drawing.Size(120, 23);
            this.AcessaContato.TabIndex = 1;
            this.AcessaContato.Text = "Acessar contatos";
            this.AcessaContato.UseVisualStyleBackColor = true;
            this.AcessaContato.Click += new System.EventHandler(this.AcessaContato_Click);
            // 
            // AcessaEvento
            // 
            this.AcessaEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcessaEvento.Location = new System.Drawing.Point(607, 100);
            this.AcessaEvento.Name = "AcessaEvento";
            this.AcessaEvento.Size = new System.Drawing.Size(100, 23);
            this.AcessaEvento.TabIndex = 2;
            this.AcessaEvento.Text = "Acessar eventos";
            this.AcessaEvento.UseVisualStyleBackColor = true;
            this.AcessaEvento.Click += new System.EventHandler(this.AcessaEvento_Click);
            // 
            // AcessaTarefa
            // 
            this.AcessaTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcessaTarefa.Location = new System.Drawing.Point(922, 100);
            this.AcessaTarefa.Name = "AcessaTarefa";
            this.AcessaTarefa.Size = new System.Drawing.Size(100, 23);
            this.AcessaTarefa.TabIndex = 3;
            this.AcessaTarefa.Text = "Acessar tarefas";
            this.AcessaTarefa.UseVisualStyleBackColor = true;
            this.AcessaTarefa.Click += new System.EventHandler(this.AcessaTarefa_Click);
            // 
            // flpContatoPrincipal
            // 
            this.flpContatoPrincipal.AutoScroll = true;
            this.flpContatoPrincipal.Location = new System.Drawing.Point(12, 175);
            this.flpContatoPrincipal.Name = "flpContatoPrincipal";
            this.flpContatoPrincipal.Size = new System.Drawing.Size(472, 221);
            this.flpContatoPrincipal.TabIndex = 5;
            // 
            // flpEventoPrincipal
            // 
            this.flpEventoPrincipal.AutoScroll = true;
            this.flpEventoPrincipal.Location = new System.Drawing.Point(502, 175);
            this.flpEventoPrincipal.Name = "flpEventoPrincipal";
            this.flpEventoPrincipal.Size = new System.Drawing.Size(290, 221);
            this.flpEventoPrincipal.TabIndex = 6;
            // 
            // flpTarefaPrincipal
            // 
            this.flpTarefaPrincipal.Location = new System.Drawing.Point(818, 175);
            this.flpTarefaPrincipal.Name = "flpTarefaPrincipal";
            this.flpTarefaPrincipal.Size = new System.Drawing.Size(303, 221);
            this.flpTarefaPrincipal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contatos favoritos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Próximos eventos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tarefas urgentes";
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpTarefaPrincipal);
            this.Controls.Add(this.flpEventoPrincipal);
            this.Controls.Add(this.flpContatoPrincipal);
            this.Controls.Add(this.AcessaTarefa);
            this.Controls.Add(this.AcessaEvento);
            this.Controls.Add(this.AcessaContato);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1149, 506);
            this.MinimumSize = new System.Drawing.Size(1149, 506);
            this.Name = "PrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchedBrain";
            this.Activated += new System.EventHandler(this.PrincipalView_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button AcessaContato;
        private Button AcessaEvento;
        private Button AcessaTarefa;
        private FlowLayoutPanel flpContatoPrincipal;
        private FlowLayoutPanel flpEventoPrincipal;
        private FlowLayoutPanel flpTarefaPrincipal;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}