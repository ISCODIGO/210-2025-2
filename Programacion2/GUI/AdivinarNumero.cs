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

        private const int NUMERO_MAXIMO = 100;
        private const int NUMERO_MINIMO = 1;
        private const int INTENTOS_MAXIMO = 10;

        public AdivinarNumero()
        {
            InitializeComponent();
        }

        private void RefrescarPantalla()
        {
            TxtNumero.Text = string.Empty;
            LblIntentos.Text = $"Intentos: {Intentos}";
        }

        private void AdivinarNumero_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            NumeroRandom = random.Next(NUMERO_MINIMO, NUMERO_MAXIMO + 1);  // random entre [1, 100]
            Intentos = INTENTOS_MAXIMO;

            RefrescarPantalla();
            LblConsejo.Text = string.Empty;

        }

        private void BtnAdivinaClick(object sender, EventArgs e)
        {
            int.TryParse(TxtNumero.Text, out int candidato);

            if (candidato < NUMERO_MINIMO || candidato > NUMERO_MAXIMO)
            {
                MessageBox.Show($"Debe escribir un numero entre {NUMERO_MINIMO} y {NUMERO_MAXIMO}");
                return;
            }

            if (candidato == NumeroRandom)
            {
                var intentosRealizados = INTENTOS_MAXIMO - Intentos + 1;
                MessageBox.Show($"Gano en {intentosRealizados} intentos");
                return;
            }
            else if (candidato < NumeroRandom)
            {
                LblConsejo.Text = "Aumenta";
            }
            else
            {
                LblConsejo.Text = "Disminuye";
            }

            string resultado = $"{candidato}: {LblConsejo.Text}";
            LstCandidatosFallidos.Items.Add(resultado);
            Intentos--;
            RefrescarPantalla();
            TxtNumero.Focus();

            if (Intentos == 0)
            {
                MessageBox.Show("Has perdido el juego");
                BtnAdivina.Enabled = false;
            }
        }
    }
}
