namespace ExercicioCapQuatro
{
    partial class FormProfessor
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbFormacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Formação:";
            // 
            // cbFormacao
            // 
            this.cbFormacao.FormattingEnabled = true;
            this.cbFormacao.Items.AddRange(new object[] {
            "Graduado",
            "Especialista",
            "Mestre",
            "Doutor",
            "Pós-Doutor"});
            this.cbFormacao.Location = new System.Drawing.Point(15, 146);
            this.cbFormacao.Name = "cbFormacao";
            this.cbFormacao.Size = new System.Drawing.Size(532, 21);
            this.cbFormacao.TabIndex = 21;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(566, 212);
            this.Controls.Add(this.cbFormacao);
            this.Controls.Add(this.label4);
            this.Name = "FormProfessor";
            this.Load += new System.EventHandler(this.FormProfessor_Load);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtEndereco, 0);
            this.Controls.SetChildIndex(this.txtNascimento, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbFormacao, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFormacao;
    }
}
