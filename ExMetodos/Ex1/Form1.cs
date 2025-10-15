namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Quadrado
        {
            public float lado;

            public float calcArea()
            {
                return this.lado * this.lado;

            }

            public float calcPerimetro()
            {
                return 4 * this.lado;
            }

            public string imprimir()
            {
                return "Lados do quadrado: " + this.lado +
                    "\nArea do quadrado: " + this.calcArea() +
                    "\nPerimetro do quadrado: " + this.calcPerimetro();
            }
        }

        Quadrado quadrado = null;
            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (quadrado == null)
                    {
                        quadrado = new Quadrado();
                    }
                    quadrado.lado = Convert.ToSingle(txtLado.Text);

                    MessageBox.Show(quadrado.imprimir());
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira um número válido!");
                }
            }
    }
}
