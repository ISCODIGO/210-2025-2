namespace S6GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno(TxtCuenta.Text, TxtNombre.Text, CmbCarrera.SelectedItem?.ToString());
            LstAlumnos.Items.Add(alumno.ToString());

            Console.WriteLine(alumno.Carrera);

            CmbCarrera.SelectedIndex = -1;
            TxtCuenta.Text = string.Empty;
            TxtNombre.Text = string.Empty;
        }
    }
}
