using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaDoisValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            float val1 = Convert.ToSingle(txt1.Text);
            float val2 = Convert.ToSingle(txt2.Text);
            float soma = val1 + val2;
            lbl1.Text = "A soma é " + soma.ToString("0.00");
            //MessageBox.Show("A soma é " + soma);
        }
    }
}
