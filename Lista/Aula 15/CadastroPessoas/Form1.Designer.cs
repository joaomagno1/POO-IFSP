namespace CadastroPessoas
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
            tab = new TabControl();
            tabCad = new TabPage();
            lblIdade = new Label();
            lblNome = new Label();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            btnGravar = new Button();
            tabListagem = new TabPage();
            btnListar = new Button();
            dgvPessoa = new DataGridView();
            tabPesquisar = new TabPage();
            lblResultado = new Label();
            lblPesquisa = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            tab.SuspendLayout();
            tabCad.SuspendLayout();
            tabListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoa).BeginInit();
            tabPesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabCad);
            tab.Controls.Add(tabListagem);
            tab.Controls.Add(tabPesquisar);
            tab.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tab.Location = new Point(13, 12);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(264, 340);
            tab.TabIndex = 0;
            // 
            // tabCad
            // 
            tabCad.Controls.Add(lblIdade);
            tabCad.Controls.Add(lblNome);
            tabCad.Controls.Add(txtIdade);
            tabCad.Controls.Add(txtNome);
            tabCad.Controls.Add(btnGravar);
            tabCad.Location = new Point(4, 24);
            tabCad.Name = "tabCad";
            tabCad.Padding = new Padding(3);
            tabCad.Size = new Size(256, 312);
            tabCad.TabIndex = 0;
            tabCad.Text = "Cadastro";
            tabCad.UseVisualStyleBackColor = true;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(17, 110);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(38, 15);
            lblIdade.TabIndex = 4;
            lblIdade.Text = "Idade:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(17, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(39, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(73, 110);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(161, 21);
            txtIdade.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 21);
            txtNome.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(17, 269);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(217, 23);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // tabListagem
            // 
            tabListagem.Controls.Add(btnListar);
            tabListagem.Controls.Add(dgvPessoa);
            tabListagem.Location = new Point(4, 24);
            tabListagem.Name = "tabListagem";
            tabListagem.Padding = new Padding(3);
            tabListagem.Size = new Size(256, 312);
            tabListagem.TabIndex = 1;
            tabListagem.Text = "Listagem";
            tabListagem.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(16, 260);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(224, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvPessoa
            // 
            dgvPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoa.Location = new Point(16, 24);
            dgvPessoa.Name = "dgvPessoa";
            dgvPessoa.ReadOnly = true;
            dgvPessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPessoa.Size = new Size(224, 163);
            dgvPessoa.TabIndex = 0;
            // 
            // tabPesquisar
            // 
            tabPesquisar.Controls.Add(lblResultado);
            tabPesquisar.Controls.Add(lblPesquisa);
            tabPesquisar.Controls.Add(txtPesquisar);
            tabPesquisar.Controls.Add(btnPesquisar);
            tabPesquisar.Location = new Point(4, 24);
            tabPesquisar.Name = "tabPesquisar";
            tabPesquisar.Size = new Size(256, 312);
            tabPesquisar.TabIndex = 2;
            tabPesquisar.Text = "Pesquisar";
            tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(23, 229);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(74, 15);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "RESULTADO";
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(23, 51);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(123, 15);
            lblPesquisa.TabIndex = 9;
            lblPesquisa.Text = "Nome a ser pesquisado:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(15, 78);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(161, 21);
            txtPesquisar.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(15, 121);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(217, 23);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tab);
            Name = "Form1";
            Text = "Form1";
            tab.ResumeLayout(false);
            tabCad.ResumeLayout(false);
            tabCad.PerformLayout();
            tabListagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPessoa).EndInit();
            tabPesquisar.ResumeLayout(false);
            tabPesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage tabCad;
        private TabPage tabListagem;
        private Label lblIdade;
        private Label lblNome;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Button btnGravar;
        private DataGridView dgvPessoa;
        private Button btnListar;
        private TabPage tabPesquisar;
        private Label lblResultado;
        private Label lblPesquisa;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
    }
}
