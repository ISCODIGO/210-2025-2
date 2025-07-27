using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10P1
{
    public class Robot
    {
        private static int secuencia = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Robot(string nombre)
        {
            Nombre = nombre;
            Id = ++Robot.secuencia;
        }

        public override string ToString()
        {
            return $"Robot {Nombre}-{Id}";
        }
    }
}
