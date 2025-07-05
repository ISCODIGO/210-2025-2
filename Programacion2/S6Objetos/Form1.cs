using S6GUI;

namespace S6Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno(txtCuenta.Text, txtNombre.Text, txtCarrera.Text);
            lstAlumnos.Items.Add(alumno.ToString());

            alumno.Carrera = "Arquictura";

            Console.WriteLine(alumno.Carrera);

            txtCarrera.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
    }
}
