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
    public partial class AdivinarNumero : Form
    {
        private int NumeroRandom { get; set; }
        private int Intentos {  get; set; }

        public AdivinarNumero()
        {
            InitializeComponent();
            

        }

        private void RefrescarPantalla()
        {
            textBox1.Text = string.Empty;
            label2.Text = $"Intentos: {Intentos}";
        }

        private void AdivinarNumero_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            NumeroRandom = random.Next(1, 101);  // random entre [1, 100]
            Intentos = 10;

            label1.Text = $"Numero: {NumeroRandom}";
            button1.Text = "Adivinar";
            RefrescarPantalla();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Intentos == 0)
            {
                MessageBox.Show("Perdio");
            }
            else
            {
                int.TryParse(textBox1.Text, out int candidato);
                if (candidato == NumeroRandom)
                {
                    MessageBox.Show("Gano");
                }
                else if (candidato < NumeroRandom)
                {
                    MessageBox.Show("Aumenta tu candidato");
                }
                else
                {
                    MessageBox.Show("Disminuye tu candidato");
                }
            }

            Intentos--;
            RefrescarPantalla();

        }
    }
}
