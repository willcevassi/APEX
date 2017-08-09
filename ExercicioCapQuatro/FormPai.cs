using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCapQuatro
{
    public partial class FormPai : Form
    {
        public List<String> valores = new List<string>();

        public FormPai()
        {
            InitializeComponent();
        }

        public virtual List<string> getValores()
        {
            List<string> toReturn = new List<string>();
            toReturn.Add(txtNome.Text);
            toReturn.Add(txtEndereco.Text);
            toReturn.Add(txtNascimento.Text);
            toReturn.Add(txtTelefone.Text);
            toReturn.Add(txtEmail.Text);
            return toReturn;
        } 



    }
}
