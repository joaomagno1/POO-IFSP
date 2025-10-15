namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Retangulo
        {
            public float altura, base1;

            public float calcArea()
            {
                return this.base1 * this.altura;
            }

            public float calcPerimetro()
            {
                return 4 * this.base1;
            }

            public string imprimir()
            {
                return "Base do retângulo: " + 
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
