namespace FormsPolideportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.Ccompeticiones objetoCompeticiones = new Clases.Ccompeticiones();
            objetoCompeticiones.mostrarJornadas(dataGridView2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clases.Ccompeticiones objetoCompeticiones = new Clases.Ccompeticiones();
            objetoCompeticiones.guardarDatos(comboBox1, textBox1, numericUpDown1, dateTimePicker1);

            objetoCompeticiones.mostrarJornadas(dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clases.Ccompeticiones objetoCompeticiones = new Clases.Ccompeticiones();

            objetoCompeticiones.cargarComboCampeonatos(comboBox1);
            objetoCompeticiones.mostrarJornadas(dataGridView2);
        }
    }
}
