using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExercicioCapQuatro
{
    public partial class FormProfessor : ExercicioCapQuatro.FormPai
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro de Professores";
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            int numero = 0;
            bool result = Int32.TryParse(txtTelefone.Text, out numero);

            if (!result)
            {
                MessageBox.Show("Digite somente números");
                TextBox controle = (TextBox)sender;
                controle.Text = string.Empty;
                controle.Focus();
            }
        }
    }
}
