using System.Collections.Generic;
using Enumerados;

namespace proyecto_clases.clases
{
     {
         public class Alumnos : Persona
         {


             public Alumnos()
             {
                 this.Activo = true;
                 this.Sueldo = 100;
             }

             public Alumnos(int idAlumno, string nombre)
             {
                 this.idAlumno = idAlumno;
                 this.nombre = nombre;
                 this.Activo = true;
             }

             public int  IdAlumnos {get; set; }

             private float Sueldo { get; set; }

             public  List<Materia> Materias {get; set; }

             public bool Activo {get; set; }
         }
     }
}