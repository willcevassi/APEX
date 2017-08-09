using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCapTres
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            MessageBox.Show(null, "Bem Vindo", null, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 15)
            {
                MessageBox.Show(null, "Nome muito grande. Favor abreviar.", null, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // textBox1.Text = toProperCase(textBox1.Text);
                textBox1.Text = textBox1.Text.ToUpper();
            }
            else
            {
                textBox1.Text = textBox1.Text.ToLower();                
            }
        }


        private static string toProperCase(string texto)
        {
            const string pattern = @"(?<=\w)(?=[AZ])";
            string resultado = Regex.Replace(texto, pattern, "", RegexOptions.None);
            return resultado.Substring(0, 1).ToUpper() + resultado.Substring(1);
        }
    }
}
