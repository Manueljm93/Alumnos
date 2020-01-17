using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio2
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private List<Materia> materias;
        private Materia ultimaMateriaAgregada;

        public Alumno(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.materias = new List<Materia>();
        }

        public void AgregarMateria(string nombre)
        {
            ultimaMateriaAgregada = new Materia(nombre);
            materias.Add(ultimaMateriaAgregada);
        }

        public void ObtenerNombreCompleto()
        {
            Console.WriteLine(this.nombre + " " + this.apellido + ":");
        }
        public List<Materia> ObtenerMaterias => materias;

        public Materia ObtenerUltimaMateriaAgregada => ultimaMateriaAgregada;
    }
}

