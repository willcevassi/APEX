using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCapSeis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 15)
            {
                MessageBox.Show("Não digite mais de 15 caracteres");
            }
            if (textBox1.Text.Contains("%"))
            {
                MessageBox.Show("Não digite %");
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Ítem");
            }

            DateTime dataSelecionada = dateTimePicker1.Value;
            if (dataSelecionada.Date.Equals(DateTime.Now.Date))
            {
                MessageBox.Show("A data não pode ser a atual");
            }
            if (dataSelecionada < new DateTime(2012,01,01))
            {
                MessageBox.Show("A data não pode menor que 2012");
            }


    }
    }
}
