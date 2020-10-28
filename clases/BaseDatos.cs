using System.Collections.Generic;

namespace proyecto_clases.clases
{

     public static class BaseDatos
     {

          static List.<Alumno> TableAlumno = new List<Alumno>();

          public static bool Guardar(Alumnos alumnos)
          {
              TablaAlumno.Add(alumno);
              return true;
          }

          public static List<Alumno> Listar()
          {
               return TablaAlumno;
          }
     }
}