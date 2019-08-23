using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autor form2 = new Autor();
            form2.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Autor form2 = new Autor();
            form2.ShowDialog();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Autor form2 = new Autor();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2;
            double result = 0.0;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);


            if (rbSoma.Checked) result = n1 + n2;
            if (rbSubtração.Checked) result = n1 - n2;
            if (rbMultiplicação.Checked) result = n1 * n2;

            res.Text = "Resultado: " + result.ToString();
            if (rbDivisão.Checked)
            {
                if(n1 >= 1 && n2 >= 1)
                {
                    result = n1 / n2;
                    res.Text = "Resultado: " + result.ToString();
                }
                else
                {
                    res.Text = "Operação não pode ser realizada";
                }
            }

            
        }
    }
}
