using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    internal class Cuenta
    {
        // atributos -> variables
        // propiedades (get, set)
        // metodos -> funciones
        private decimal _saldo;

        public const decimal LIMITE_RETIRO = 5000;
        public const decimal LIMITE_DEPOSITO = 200_000;

        // El saldo no puede ser negativo
        // El saldo no puede exceder L1,000,000
        public decimal Saldo 
        {
            get { return _saldo; }  // mostrar
            set {
                if (value >= 0 && value <= 1_000_000)
                {
                    _saldo = value;
                }
            }  // modificar
        }

        public string Cliente { get; set; }

        public Cuenta(int saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Retirar(decimal monto)
        {
            if (monto < 0)
            {
                throw new ArgumentException("Monto negativo");
            }

            if (monto > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            if (monto > LIMITE_RETIRO)
            {
                throw new ArgumentException($"No puede superar el limite: L{LIMITE_RETIRO}");
            }

            if (monto % 100 != 0)
            {
                throw new ArgumentException("Debe ser un monto multiplo de 100 o 500");
            }

            Saldo -= monto;
        }

        public void Depositar(decimal monto)
        {
            if (monto < 0)
            {
                throw new ArgumentException("Monto negativo");
            }

            if (monto > LIMITE_DEPOSITO)
            {
                throw new ArgumentException($"No puede superar el limite: {LIMITE_DEPOSITO}");
            }

        }

        public override string ToString()
        {
            return $"Propietario: {Cliente} - L{Saldo}";
        }

    }
}
