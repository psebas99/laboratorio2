using Operaciones.Edu.Kinal.Lab.Interfaces;

namespace Operaciones.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, Ioperaciones
    {   
        public string cui { get; set; }
        public string cargo { get; set; }

        public Profesor() : base(){   
            
        }
         public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
        {
            this.cui = cui;
            this.cargo = cargo;
        }
        
        public bool Eliminar(string asignatura)
        {
         Console.WriteLine($"Se ha eliminado la asignatura de {this.apellidos} {this.nombres}");
         return true;
        }

        public void ListasMisDatos(string identificador)
        {
          Console.WriteLine($"{this.uuid} {this.apellidos} {this.nombres} {this.cargo}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia de {this.apellidos}{this.nombres}");
        }
    }
}