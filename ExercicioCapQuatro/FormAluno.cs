using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExercicioCapQuatro
{
    public partial class FormAluno : ExercicioCapQuatro.FormPai
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro de Aluno";
        }
    }
}
