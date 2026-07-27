namespace SistemaDePolideportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Instancias (creas) el formulario al que quieres ir
            // Cambia "NombreDelOtroFormulario" por el nombre real de tu form (ej. FormularioPrincipal)
            Deportes nuevoForm = new Deportes();

            // 2. Muestras el nuevo formulario
            nuevoForm.Show();

            // 3. (Opcional) Ocultas el formulario actual para que no se queden ventanas acumuladas
            this.Hide();
        }
    }
}
