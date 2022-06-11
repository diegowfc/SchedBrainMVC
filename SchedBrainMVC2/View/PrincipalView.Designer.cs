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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flpContatoPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEventoPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTarefaPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao SchedBrain!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(81, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Acessar contatos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(402, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Acessar eventos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(713, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Acessar tarefas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // flpContatoPrincipal
            // 
            this.flpContatoPrincipal.Location = new System.Drawing.Point(12, 129);
            this.flpContatoPrincipal.Name = "flpContatoPrincipal";
            this.flpContatoPrincipal.Size = new System.Drawing.Size(292, 309);
            this.flpContatoPrincipal.TabIndex = 5;
            // 
            // flpEventoPrincipal
            // 
            this.flpEventoPrincipal.AutoScroll = true;
            this.flpEventoPrincipal.Location = new System.Drawing.Point(310, 129);
            this.flpEventoPrincipal.Name = "flpEventoPrincipal";
            this.flpEventoPrincipal.Size = new System.Drawing.Size(292, 309);
            this.flpEventoPrincipal.TabIndex = 6;
            // 
            // flpTarefaPrincipal
            // 
            this.flpTarefaPrincipal.Location = new System.Drawing.Point(608, 129);
            this.flpTarefaPrincipal.Name = "flpTarefaPrincipal";
            this.flpTarefaPrincipal.Size = new System.Drawing.Size(292, 309);
            this.flpTarefaPrincipal.TabIndex = 7;
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 459);
            this.Controls.Add(this.flpTarefaPrincipal);
            this.Controls.Add(this.flpEventoPrincipal);
            this.Controls.Add(this.flpContatoPrincipal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "PrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.PrincipalView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel flpContatoPrincipal;
        private FlowLayoutPanel flpEventoPrincipal;
        private FlowLayoutPanel flpTarefaPrincipal;
    }
}