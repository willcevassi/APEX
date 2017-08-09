namespace ExerciciosCapDois
{
    partial class MeuFormulario
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
            this.lblMeuLabel = new System.Windows.Forms.Label();
            this.txtMeuTextBox = new System.Windows.Forms.TextBox();
            this.pnlMeuPainel = new System.Windows.Forms.Panel();
            this.btnMeuBotao = new System.Windows.Forms.Button();
            this.nudMeuCampoNumerico = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbMeuComboBox = new System.Windows.Forms.ComboBox();
            this.dgvMinhaGrade = new System.Windows.Forms.DataGridView();
            this.pnlMeuPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeuCampoNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinhaGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMeuLabel
            // 
            this.lblMeuLabel.AutoSize = true;
            this.lblMeuLabel.Location = new System.Drawing.Point(13, 13);
            this.lblMeuLabel.Name = "lblMeuLabel";
            this.lblMeuLabel.Size = new System.Drawing.Size(76, 13);
            this.lblMeuLabel.TabIndex = 0;
            this.lblMeuLabel.Text = "MeuFormulario";
            // 
            // txtMeuTextBox
            // 
            this.txtMeuTextBox.Location = new System.Drawing.Point(16, 30);
            this.txtMeuTextBox.Name = "txtMeuTextBox";
            this.txtMeuTextBox.Size = new System.Drawing.Size(256, 20);
            this.txtMeuTextBox.TabIndex = 1;
            this.txtMeuTextBox.Text = "MeuTextBox";
            // 
            // pnlMeuPainel
            // 
            this.pnlMeuPainel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlMeuPainel.Controls.Add(this.cbMeuComboBox);
            this.pnlMeuPainel.Controls.Add(this.nudMeuCampoNumerico);
            this.pnlMeuPainel.Controls.Add(this.btnMeuBotao);
            this.pnlMeuPainel.Location = new System.Drawing.Point(16, 56);
            this.pnlMeuPainel.Name = "pnlMeuPainel";
            this.pnlMeuPainel.Size = new System.Drawing.Size(256, 110);
            this.pnlMeuPainel.TabIndex = 2;
            // 
            // btnMeuBotao
            // 
            this.btnMeuBotao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeuBotao.Location = new System.Drawing.Point(13, 14);
            this.btnMeuBotao.Name = "btnMeuBotao";
            this.btnMeuBotao.Size = new System.Drawing.Size(229, 38);
            this.btnMeuBotao.TabIndex = 0;
            this.btnMeuBotao.Text = "Meu Botão";
            this.btnMeuBotao.UseVisualStyleBackColor = false;
            this.btnMeuBotao.Click += new System.EventHandler(this.btnMeuBotao_Click);
            // 
            // nudMeuCampoNumerico
            // 
            this.nudMeuCampoNumerico.Location = new System.Drawing.Point(13, 73);
            this.nudMeuCampoNumerico.Name = "nudMeuCampoNumerico";
            this.nudMeuCampoNumerico.Size = new System.Drawing.Size(37, 20);
            this.nudMeuCampoNumerico.TabIndex = 1;
            this.nudMeuCampoNumerico.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cbMeuComboBox
            // 
            this.cbMeuComboBox.FormattingEnabled = true;
            this.cbMeuComboBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.cbMeuComboBox.Location = new System.Drawing.Point(57, 73);
            this.cbMeuComboBox.Name = "cbMeuComboBox";
            this.cbMeuComboBox.Size = new System.Drawing.Size(185, 21);
            this.cbMeuComboBox.TabIndex = 2;
            // 
            // dgvMinhaGrade
            // 
            this.dgvMinhaGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinhaGrade.Location = new System.Drawing.Point(279, 30);
            this.dgvMinhaGrade.Name = "dgvMinhaGrade";
            this.dgvMinhaGrade.Size = new System.Drawing.Size(410, 162);
            this.dgvMinhaGrade.TabIndex = 3;
            // 
            // MeuFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 261);
            this.Controls.Add(this.dgvMinhaGrade);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pnlMeuPainel);
            this.Controls.Add(this.txtMeuTextBox);
            this.Controls.Add(this.lblMeuLabel);
            this.Name = "MeuFormulario";
            this.pnlMeuPainel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMeuCampoNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinhaGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeuLabel;
        private System.Windows.Forms.TextBox txtMeuTextBox;
        private System.Windows.Forms.Panel pnlMeuPainel;
        private System.Windows.Forms.Button btnMeuBotao;
        private System.Windows.Forms.ComboBox cbMeuComboBox;
        private System.Windows.Forms.NumericUpDown nudMeuCampoNumerico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvMinhaGrade;
    }
}

