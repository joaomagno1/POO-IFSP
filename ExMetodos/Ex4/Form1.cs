namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Calculadora
        {
            public float num1, num2;

            public float somar()
            {
                return num1 + num2;
            }
            public float subtrair()
            {
                return num1 - num2;
            }
            public float dividir()
            {
                return num1 / num2;
            }
            public float multiplicar()
            {
                return num1 * num2;
            }
        }

        Calculadora calculadora = new Calculadora();

        private void btnSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resultado: " + somar);
        }
    }
}
