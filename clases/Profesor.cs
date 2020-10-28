using System.Collections.Generic;
   
   namespace Proyecto_clases.Clases
{
    public class Profesor :Persona  
    {
      public Profesor()
       {
             this.Activo = true;
            
       } 
            public int IdProfesor { get; set; } 
            public bool Activo { get; set; }
             public List<Profesor> Profesores { get; set; } 
    }
   
}