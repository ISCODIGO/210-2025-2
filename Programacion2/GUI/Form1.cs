using System.Globalization;
using S7;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Cuenta CuentaObjeto { get; set; }
        private CultureInfo CultureHN { get; set; }
        public Form1()
        {
            InitializeComponent();
            CuentaObjeto = new Cuenta(0);
            CuentaObjeto.Cliente = "anonimo";
            CultureHN = new CultureInfo("es-HN");
        }

        private void RefrescarDatos()
        {
            label3.Text = CuentaObjeto.Cliente;
            label4.Text = CuentaObjeto.Saldo.ToString("C", CultureHN);
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Deposito
            decimal.TryParse(textBox1.Text, out decimal monto);
            try
            {
                CuentaObjeto.Depositar(monto);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RefrescarDatos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Retiro
            decimal.TryParse(textBox1.Text, out decimal monto);
            try
            {
                CuentaObjeto.Retirar(monto);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefrescarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteEditable.Visible = true;
            ClienteEditable.Text = CuentaObjeto.Cliente;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CuentaObjeto.Cliente = ClienteEditable.Text;
            ClienteEditable.Visible = false;
            button4.Visible = false;
            RefrescarDatos();
        }
    }
}
