using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {            
            var corte = false;
            GerenteDeAlumnos gerente = new GerenteDeAlumnos();
            while (!corte)
            {                
                Console.WriteLine("Agregue Nombre:");
                string nombreAlumno = Console.ReadLine();
                Console.WriteLine("Agregue Apellido:");
                string apellidoAlumno = Console.ReadLine();
                gerente.AgregarAlumno(nombreAlumno, apellidoAlumno);
                var alumno = gerente.ObtenerUltimoAlumnoAgregado;
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Agregue materia al alumno " + nombreAlumno + " " + apellidoAlumno + ":");
                    alumno.AgregarMateria(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota de esa materia:");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    alumno.ObtenerUltimaMateriaAgregada.AgregarNota(valor);
                }
                var salir = false;
                var contadorIntentosFallidos = 0;
                while (!salir)
                {
                    Console.WriteLine("Quiere seguir agregando? S/N");
                    var respuesta = Console.ReadLine();
                    if (respuesta == "S")
                    {
                        salir = true;
                    }
                    else if (respuesta != "S" & respuesta != "N")
                    {
                        Console.WriteLine("Ingreso incorrecto " + (++contadorIntentosFallidos));
                    }
                    else if (respuesta == "N")
                    {
                        salir = true;
                        corte = true;
                        foreach (Alumno a in gerente.ObtenerAlumnos)
                        {
                            a.ObtenerNombreCompleto();
                            foreach (Materia materia in a.ObtenerMaterias)
                            {
                                Console.Write($"{materia.nombre}: ");
                                foreach (Nota nota in materia.ObtenerNotas)
                                {
                                    Console.Write($"{nota.nota}");
                                }
                                Console.WriteLine("");
                            }
                        }
                    }
                }               
            }            
        }
    }
}
