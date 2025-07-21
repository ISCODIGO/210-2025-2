using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace S9Obj
{
    public class Personaje
    {
        // Propiedades
        public int Defensa { get; }
        public int Ataque { get; }
        private int Vida { get; set; }


        // constructor
        public Personaje(int def, int atq)
        {
            Defensa = def;
            Ataque = atq;
            Vida = 100;
        }

        public void Atacar(Personaje enemigo)
        {
            // atacante es mas fuerte que el enemigo
            if (this.Ataque > enemigo.Defensa)
            {
                enemigo.Vida = 0;  // lo destruye
            }

            // el atacante es debil
            if (this.Ataque <= enemigo.Defensa)
            {
                this.Vida -= ReduccionVida(enemigo.Defensa);
            }
        }

        private int ReduccionVida(int defEnemigo)
        {
            int diferencia = defEnemigo - this.Ataque;
            double porcentajeMax = diferencia * 100.0 / this.Ataque;
            double porcentajeMin = porcentajeMax * 0.1;
            Random rand = new Random();
            int perdida = rand.Next(
                (int)porcentajeMin,
                (int)porcentajeMax + 1
            );

            Console.WriteLine("*** Perdida " + perdida);
            return perdida;
        }


        public override string ToString()
        {
            return $"ATQ: {this.Ataque} / DEF: {this.Defensa} / LIF: {this.Vida}";
        }
    }
}
