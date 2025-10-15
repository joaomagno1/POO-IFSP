namespace Exemplo_VIII
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
            groupBox1 = new GroupBox();
            rdbEsconder = new RadioButton();
            rdbMostrar = new RadioButton();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbEsconder);
            groupBox1.Controls.Add(rdbMostrar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 86);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opções";
            // 
            // rdbEsconder
            // 
            rdbEsconder.AutoSize = true;
            rdbEsconder.Location = new Point(21, 47);
            rdbEsconder.Name = "rdbEsconder";
            rdbEsconder.Size = new Size(73, 19);
            rdbEsconder.TabIndex = 1;
            rdbEsconder.TabStop = true;
            rdbEsconder.Text = "Esconder";
            rdbEsconder.UseVisualStyleBackColor = true;
            rdbEsconder.CheckedChanged += rdbEsconder_CheckedChanged;
            // 
            // rdbMostrar
            // 
            rdbMostrar.AutoSize = true;
            rdbMostrar.Location = new Point(21, 22);
            rdbMostrar.Name = "rdbMostrar";
            rdbMostrar.Size = new Size(66, 19);
            rdbMostrar.TabIndex = 0;
            rdbMostrar.TabStop = true;
            rdbMostrar.Text = "Mostrar";
            rdbMostrar.UseVisualStyleBackColor = true;
            rdbMostrar.CheckedChanged += rdbMostrar_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(171, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 78);
            panel1.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 48);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 115);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Exericío 3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbEsconder;
        private RadioButton rdbMostrar;
        private Panel panel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
