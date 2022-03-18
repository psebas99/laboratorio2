using Operaciones.Edu.Kinal.Lab.Interfaces;

namespace Operaciones.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, Ioperaciones
    {
        public string carne { get; set; }
        public int numeroCreditos { get; set; }

        public Alumno(): base()
        {

        }
        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
            : base(uuid, apellidos, nombres, email)
        {
            this.carne = carne;
            this.numeroCreditos = numeroCreditos;
        }

        public bool Eliminar(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.apellidos} {this.nombres},Perdera la cantidad de creditos de {this.numeroCreditos}");
            return true;
        }

        public void ListasMisDatos(string identificador)
        {
            Console.WriteLine($"{this.uuid} {this.apellidos} {this.nombres} {this.numeroCreditos}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia de {this.apellidos} {this.nombres}");
        }
    }
}