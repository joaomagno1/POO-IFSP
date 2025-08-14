namespace Exemplo_V
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpUm = new GroupBox();
            lblMedia = new Label();
            lblNota3 = new Label();
            lblNota2 = new Label();
            lblNota1 = new Label();
            lblEnunciado = new Label();
            btnCalcular = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            grpUm.SuspendLayout();
            SuspendLayout();
            // 
            // grpUm
            // 
            grpUm.Controls.Add(textBox3);
            grpUm.Controls.Add(textBox2);
            grpUm.Controls.Add(textBox1);
            grpUm.Controls.Add(lblNota3);
            grpUm.Controls.Add(lblNota2);
            grpUm.Controls.Add(lblNota1);
            grpUm.Controls.Add(lblEnunciado);
            grpUm.Location = new Point(49, 46);
            grpUm.Name = "grpUm";
            grpUm.Size = new Size(345, 223);
            grpUm.TabIndex = 0;
            grpUm.TabStop = false;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.BackColor = Color.Red;
            lblMedia.Location = new Point(265, 330);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(46, 15);
            lblMedia.TabIndex = 5;
            lblMedia.Text = "Média: ";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(22, 159);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(50, 15);
            lblNota3.TabIndex = 4;
            lblNota3.Text = "3° Nota:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(22, 120);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(50, 15);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "2° Nota:";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(22, 81);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(50, 15);
            lblNota1.TabIndex = 2;
            lblNota1.Text = "1° Nota:";
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Location = new Point(35, 35);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(146, 15);
            lblEnunciado.TabIndex = 1;
            lblEnunciado.Text = "Digite as 3 notas do aluno:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(84, 326);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 23);
            textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 412);
            Controls.Add(lblMedia);
            Controls.Add(grpUm);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Somar Média";
            grpUm.ResumeLayout(false);
            grpUm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpUm;
        private Label lblMedia;
        private Label lblNota3;
        private Label lblNota2;
        private Label lblNota1;
        private Label lblEnunciado;
        private Button btnCalcular;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
