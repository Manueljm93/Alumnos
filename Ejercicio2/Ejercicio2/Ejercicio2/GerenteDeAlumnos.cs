using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class GerenteDeAlumnos
    {
        private List<Alumno> alumnos;
        private Alumno ultimoAlumnoAgregado;

        public GerenteDeAlumnos()
        {
            this.alumnos = new List<Alumno>();
        }

        public void AgregarAlumno(string nombre, string apellido)
        {
            ultimoAlumnoAgregado = new Alumno(nombre, apellido);
            alumnos.Add(ultimoAlumnoAgregado);
        }
        
        public List<Alumno> ObtenerAlumnos => alumnos;
        
        public Alumno ObtenerUltimoAlumnoAgregado => ultimoAlumnoAgregado;
    }
}
