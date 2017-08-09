using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosCapDois
{
    public partial class MeuFormulario : Form
    {
        public MeuFormulario()
        {
            InitializeComponent();
        }

        private void btnMeuBotao_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Control controle in this.Controls)
            {
                sb.AppendLine(controle.Name);
            }

            MessageBox.Show(this, sb.ToString(), "Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
         }
    }
}
