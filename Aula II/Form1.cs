namespace Aula_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSaida_Click(object sender, EventArgs e)
        {

        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = "Ol� Meus Amigos!";
        }
        private void btnTexto_Click(object sender, EventArgs e)
        {
            txtSa�da.Text = txtEntrada.Text;
        }

        private void txtSa�da_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
