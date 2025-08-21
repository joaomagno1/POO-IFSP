namespace Exemplo_VII
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
            gpBox1 = new GroupBox();
            ckbEstudar = new CheckBox();
            ckbLivro = new CheckBox();
            ckbCinema = new CheckBox();
            ckbComer = new CheckBox();
            ckbDormir = new CheckBox();
            btnVerify = new Button();
            btnExit = new Button();
            gpBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gpBox1
            // 
            gpBox1.Controls.Add(ckbEstudar);
            gpBox1.Controls.Add(ckbLivro);
            gpBox1.Controls.Add(ckbCinema);
            gpBox1.Controls.Add(ckbComer);
            gpBox1.Controls.Add(ckbDormir);
            gpBox1.Location = new Point(12, 21);
            gpBox1.Name = "gpBox1";
            gpBox1.Size = new Size(164, 183);
            gpBox1.TabIndex = 0;
            gpBox1.TabStop = false;
            gpBox1.Text = "O que eu gosto de fazer:";
            // 
            // ckbEstudar
            // 
            ckbEstudar.AutoSize = true;
            ckbEstudar.Location = new Point(12, 138);
            ckbEstudar.Name = "ckbEstudar";
            ckbEstudar.Size = new Size(65, 19);
            ckbEstudar.TabIndex = 4;
            ckbEstudar.Text = "Estudar";
            ckbEstudar.UseVisualStyleBackColor = true;
            // 
            // ckbLivro
            // 
            ckbLivro.AutoSize = true;
            ckbLivro.Location = new Point(12, 113);
            ckbLivro.Name = "ckbLivro";
            ckbLivro.Size = new Size(89, 19);
            ckbLivro.TabIndex = 3;
            ckbLivro.Text = "Ler um livro";
            ckbLivro.UseVisualStyleBackColor = true;
            // 
            // ckbCinema
            // 
            ckbCinema.AutoSize = true;
            ckbCinema.Location = new Point(12, 88);
            ckbCinema.Name = "ckbCinema";
            ckbCinema.Size = new Size(91, 19);
            ckbCinema.TabIndex = 2;
            ckbCinema.Text = "Ir ao cinema";
            ckbCinema.UseVisualStyleBackColor = true;
            // 
            // ckbComer
            // 
            ckbComer.AutoSize = true;
            ckbComer.Location = new Point(12, 63);
            ckbComer.Name = "ckbComer";
            ckbComer.Size = new Size(62, 19);
            ckbComer.TabIndex = 1;
            ckbComer.Text = "Comer";
            ckbComer.UseVisualStyleBackColor = true;
            // 
            // ckbDormir
            // 
            ckbDormir.AutoSize = true;
            ckbDormir.Location = new Point(12, 38);
            ckbDormir.Name = "ckbDormir";
            ckbDormir.Size = new Size(63, 19);
            ckbDormir.TabIndex = 0;
            ckbDormir.Text = "Dormir";
            ckbDormir.UseVisualStyleBackColor = true;
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(12, 238);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(164, 23);
            btnVerify.TabIndex = 1;
            btnVerify.Text = "Verificar";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(199, 238);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 290);
            Controls.Add(btnExit);
            Controls.Add(btnVerify);
            Controls.Add(gpBox1);
            Name = "Form1";
            Text = "Exercicío 2";
            gpBox1.ResumeLayout(false);
            gpBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpBox1;
        private CheckBox ckbEstudar;
        private CheckBox ckbLivro;
        private CheckBox ckbCinema;
        private CheckBox ckbComer;
        private CheckBox ckbDormir;
        private Button btnVerify;
        private Button btnExit;
    }
}
