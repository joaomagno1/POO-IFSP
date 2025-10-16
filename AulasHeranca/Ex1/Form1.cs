namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();
            car.Descricao = txtDesc.Text;
            car.Capacidade = Convert.ToInt32(txtCap.Text);
            car.Quilometragem = Convert.ToDouble(txtKm.Text);

            MessageBox.Show($"Descrição: {car.Descricao} \n" +
                            $"Capacidade: {car.Capacidade}\n" +
                            $"Quilometragem: {car.Quilometragem}");
        }

        private void btnAviao_Click(object sender, EventArgs e)
        {
            Aviao av = new Aviao();
            av.Descricao = txtDesc.Text;
            av.Capacidade = Convert.ToInt32(txtCap.Text);
            av.Horas = Convert.ToInt32(txtHoras.Text);

            MessageBox.Show($"Descrição: {av.Descricao} \n" +
                            $"Capacidade: {av.Capacidade}\n" +
                            $"Horas de voo: {av.Horas}");
        }
    }
}
