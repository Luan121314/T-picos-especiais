namespace NotaCruzerio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.notaAf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblConceito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota na AF";
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(201, 62);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(100, 20);
            this.nota1.TabIndex = 3;
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(201, 103);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(100, 20);
            this.nota2.TabIndex = 4;
            // 
            // notaAf
            // 
            this.notaAf.Location = new System.Drawing.Point(201, 151);
            this.notaAf.Name = "notaAf";
            this.notaAf.Size = new System.Drawing.Size(100, 20);
            this.notaAf.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(111, 243);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(155, 18);
            this.lblNota.TabIndex = 7;
            this.lblNota.Text = "Nota final disciplina";
            // 
            // lblConceito
            // 
            this.lblConceito.AutoSize = true;
            this.lblConceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceito.Location = new System.Drawing.Point(111, 291);
            this.lblConceito.Name = "lblConceito";
            this.lblConceito.Size = new System.Drawing.Size(179, 16);
            this.lblConceito.TabIndex = 8;
            this.lblConceito.Text = "Aprovado ou Reprovado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConceito);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notaAf);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.TextBox notaAf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblConceito;
    }
}

