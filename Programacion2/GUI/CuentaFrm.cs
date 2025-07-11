using System.Globalization;
using S7;

namespace GUI
{
    public partial class CuentaFrm : Form
    {
        private Cuenta CuentaObjeto { get; set; }
        private CultureInfo CultureHN { get; set; }
        public CuentaFrm()
        {
            InitializeComponent();
            CuentaObjeto = new Cuenta(0);
            CuentaObjeto.Cliente = "anonimo";
            CultureHN = new CultureInfo("es-HN");
        }

        private void RefrescarDatos()
        {
            ClienteLabel.Text = CuentaObjeto.Cliente;
            SaldoLabel.Text = CuentaObjeto.Saldo.ToString("C", CultureHN);
            MontoTexto.Text = string.Empty;
            MontoTexto.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Deposito
            decimal.TryParse(MontoTexto.Text, out decimal monto);
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
            decimal.TryParse(MontoTexto.Text, out decimal monto);
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

        private void BtnEditarClienteClick(object sender, EventArgs e)
        {
            ClienteEditable.Visible = true;
            ClienteEditable.Text = CuentaObjeto.Cliente;
            BtnEditarCliente.Enabled = false;
            BtnGuardarCliente.Visible = true;
        }

        private void BtnGuardarClienteClick(object sender, EventArgs e)
        {
            CuentaObjeto.Cliente = ClienteEditable.Text;
            ClienteEditable.Visible = false;
            BtnEditarCliente.Enabled = true;
            BtnGuardarCliente.Visible = false;
            RefrescarDatos();
        }
    }
}
