using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaFrm form1 = new CuentaFrm();
            //form1.ShowDialog(this);
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdivinarNumero form2 = new AdivinarNumero();
            form2.Show();
        }
    }
}
