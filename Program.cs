using System;
using proyecto_clases_clases;


namespace proyecto_clases;


{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while(!salir)
            {
                console.clear();
                console.writeline("teclee una opcion: ");
                int opcion = int.parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                      salir = true
                    break;
                    case 1:
                      Guardaralumno();
                      break;
                    case 2:
                       Listaralumnos();
                       break;
                    default:
                      Console.WriteLine("Opcion no valida ");
                      Console.ReadKey();
                      break;
                }
            
            }
            private static voil listarAlumnos ()
         
            {
                Console.Clear();

                foreach (Alumnos item in  BaseDatos.listar())
                {
                    Console.WriteLine($"(item.Idalumnos) (item.Nombre)");
                }
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();

            }
            
            private static void GuardarAlumnos()
            {
               
               Alumno alumno =  new Alumno();

               Console.Clear();
               Console.WriteLine("Alta de alunmos");
               Console.WriteLine("__________________");

               Console.WriteLine("Codigo: ");
               alumno.IdAlumno = int.Parse(Console.ReadLine());

               Console.WriteLine("Nombre: ");
               alumno.Nombre = Console.ReadLine();

               BaseDatos.Guardar(alunmo);
            }

            
        }
    }
}
