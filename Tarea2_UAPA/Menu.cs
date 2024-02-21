namespace Tarea2_UAPA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void calcularNomina_Click(object sender, EventArgs e)
        {
            CalcularNomina calcularNomina = new CalcularNomina();
            this.Hide();
            calcularNomina.ShowDialog();
            this.Show();

        }

        private void calcularNota_Click(object sender, EventArgs e)
        {
            CalcularNota calcularNota = new CalcularNota();
            this.Hide();
            calcularNota.ShowDialog();
            this.Show();
        }
    }
}