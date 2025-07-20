using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S9Obj
{
    public class Secuencia
    {
        // private: solo visible a nivel de la clase u objeto
        // static: pertenece a la clase
        private static int valorActual;

        // Un constructor normalmente es public.
        // Al colocarse private se evita crear directamente objetos.
        private Secuencia()
        {
        }

        public static void Iniciar()
        {
            valorActual = 0;
        }

        public static int Siguiente()
        {
            return valorActual++;
        }
    }
}
