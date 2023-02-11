using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            promedio objpromedio = new promedio();
            
            objpromedio.nombre = txtNombre.Text;
            objpromedio.nota1 = int.Parse(txtnota1.Text);
            objpromedio.nota2 = int.Parse(txtnota2.Text);
            objpromedio.nota3 = int.Parse(txtnota3.Text);
            objpromedio.nota4 = int.Parse(txtnota4.Text);

            lblNotaBaja.Text = objpromedio.notaBaja().ToString();
            lblPromedio.Text = objpromedio.Promedio().ToString(); 
            lblCondicion.Text = objpromedio.condicion();


        }
    }
}
