namespace ExerciciosPOO0309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Empregado
        {
            public string nome, dept;
            public double hrsT;
            public double salHr;

            public string mostraDados()
            {
                return "Nome do funcionário: " + nome +
                "\nDepartamento: " + dept +
                "\nHoras trabalhadas: " + hrsT +
                "\nValor hora: " + salHr +
                "\nSalário mensal: " + calcSal();
            }

            public double calcSal()
            {
                return this.hrsT * this.salHr;
            }
        }
        Empregado e1 = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcSal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(e1.calcSal().ToString());
        }

        private void btnMostraDados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(e1.mostraDados());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(e1 == null)
            {
                e1 = new();
                e1.nome = txtNome.Text;
                e1.dept = txtDept.Text;
                e1.hrsT = txtHrsT.Text.ToString();
                e1.salHr = txtValorH.Text.ToString();
            }
            else
            {
                MessageBox.Show("Pessoa já cadastrada!");
            }
        }
    }
}
