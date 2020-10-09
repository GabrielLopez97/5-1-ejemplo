using.System.collections.Generic;

namespace proyecto_clases.clases
{

     public static class BaseDatos
     {

          static List.<Alunmos> TableAlumno =  new List<Alumno>();

          public static bool Guardar(Alunmos alumnos)
          {
              TablaAlunmo.Add(alumno);
              return true;
          }

          public static List<Alumno> Listar()
          {
               return TablaAlumno;
          }
     }
}