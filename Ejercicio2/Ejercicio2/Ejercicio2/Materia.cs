using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio2
{
    public class Materia
    {
        public string nombre;
        private List<Nota> notas;
        public Materia(string nombre)
        {
            this.notas = new List<Nota>();
            this.nombre = nombre;
        }

        public void AgregarNota(int nota)
        {
            notas.Add(new Nota(nota));
        }

        public List<Nota> ObtenerNotas => notas;
    }
}
