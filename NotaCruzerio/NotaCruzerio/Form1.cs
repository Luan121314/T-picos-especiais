using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaCruzerio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                float n1 = Convert.ToSingle(nota1.Text);
                float n2 = Convert.ToSingle(nota2.Text);
                float Af = Convert.ToSingle(notaAf.Text);
                float media = (n1 + n2) / 2;
                float notaFinal = 0;
            

           
            

            if(media >= 6 )
            {
                lblConceito.Text = "Aprovado";
                lblNota.Text = "Nota final na disciplina " + (n1 + n2);
                lblConceito.ForeColor = Color.Green;
            }
            else if (media >= 1) 
            {
                lblConceito.Text = "Aprovado";
                lblConceito.ForeColor = Color.Green;
                float maior = 0;
                if (n1 > n2) maior = n1; else maior = n2;
                notaFinal = maior + Af;
                lblNota.Text = "Nota final na disciplina " + notaFinal;
            }
            else
            {
                lblConceito.Text = "Reprovado";
                lblNota.Text = "Nota final na disciplina " + notaFinal;
                lblConceito.ForeColor = Color.Red;
            }
            }
            catch (Exception ex) { }
        }
    }
}
