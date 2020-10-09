using System.Collections.Generic;

namespace proyecto_clases.clases
{
     {
         public class Alumnos : Persona
         {


             public Alunmos()
             {
                 this.Activo = true;
                 this.Sueldo = 100;
             }

             public Alunmo(int idAlumno, string nombre)
             {
                 this.IdAlunmo = idAlunmo;
                 this.Nombre = nombre;
                 this.Activo = true;
             }

             public int  IdAlumnos {get; set; }

             private float Sueldo { get; set; }

             public  List<Materia> Materias {get; set; }

             public bool Activo {get; set; }
         }
     }
}