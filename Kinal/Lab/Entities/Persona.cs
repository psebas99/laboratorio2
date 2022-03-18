namespace Operaciones.Edu.Kinal.Lab.Entities
{
    public abstract class Persona 
    {
        public override string ToString(){
            return uuid;
        }
        public string uuid { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string email { get; set; }
        

        public abstract void TomarAsistencia();
        public Persona()
        {
        }
        public Persona(string uuid, string apellidos, string nombres, string email)
        {
            this.uuid = uuid;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.email = email;
        }
        
    }
}