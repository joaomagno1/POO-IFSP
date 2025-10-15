namespace Exemplo_VII
{
    public partial class Form1 : Form
    {
        string hobbies;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            hobbies = "";
            if(ckbDormir.Checked)
            {
                hobbies = hobbies + "\nDormir\n";
            }
            if (ckbComer.Checked)
            {
                hobbies = hobbies + " \nComer\n";
            }
            if (ckbCinema.Checked)
            {
                hobbies = hobbies + " \nIr ao cinema\n";
            }
            if (ckbLivro.Checked)
            {
                hobbies = hobbies + " \nLer um livro\n";
            }
            if (ckbEstudar.Checked)
            {
                hobbies = hobbies + " \nEstudar\n";
            }
            if(hobbies == "")
            {
                MessageBox.Show("Nenhum hobbie foi selecionado");
            }
            else
            {
                MessageBox.Show("Hobbies que você gosta: \n" + hobbies);
            }
        }


    }
}
