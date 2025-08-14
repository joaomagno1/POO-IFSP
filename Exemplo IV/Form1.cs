namespace Exemplo_IV
{
    public partial class Projeto4 : Form
    {
        int num1, num2, soma, subtrai, multiplica, divide;
        public Projeto4()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            soma = num1 + num2;

            txtResultado.Text = soma.ToString();
            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            subtrai = num1 - num2;

            txtResultado.Text = subtrai.ToString();
            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            multiplica = num1 * num2;

            txtResultado.Text = multiplica.ToString();
            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            divide = num1 / num2;

            txtResultado.Text = divide.ToString();
            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
