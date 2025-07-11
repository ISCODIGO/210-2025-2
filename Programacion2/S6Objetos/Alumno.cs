using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace S6GUI
{
    internal class Alumno
    {
        // atributos
        string cuenta;
        string nombre;
        string? carrera;
        DateOnly fechaIngreso;

        // propiedades
        public string? Carrera
        {
            get {  return carrera; }
            set { carrera = value; }
        }

        // metodos
        // 1. Constructores
        // 2. Accesores/Getter
        // 3. Modificadores/Setter
        // 4. Destructor
        // 5. Auxiliares

        public Alumno(string cuenta, string nombre, string? carrera)
        {
            this.cuenta = cuenta;
            this.nombre = nombre;
            this.carrera = carrera;
            var ahora = DateTime.Now;
            fechaIngreso = new DateOnly(ahora.Year, ahora.Month, ahora.Day);
        }

        // Getter
        public string GetCuenta()
        {
            return cuenta;
        }

        // Setter
        public void SetCarrera(string? carrera)
        {
            this.carrera = carrera;
        }

        public string ToString()
        {
            return $"{cuenta} {nombre}: {carrera}";            
        }
    }
}
