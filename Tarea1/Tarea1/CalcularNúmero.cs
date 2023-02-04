using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class CalcularNúmero : Form
    {
        public CalcularNúmero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0, parimpar = 0;
            num = int.Parse(textBox1.Text);
            parimpar = num / 2;
            if (parimpar > 0)
            {
                textBox2.Text = $"El Número {num} Par Positivo";
            }
            else if (parimpar < 0)
            {
                textBox2.Text = $"El Número {num} Impar Negativo";
            }
            else {
                textBox2.Text = $"El Número {num} es cero";
            }
        }
    }
}
