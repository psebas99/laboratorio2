
using Operaciones.Edu.Kinal.Lab.Entities;
using Operaciones.Edu.Kinal.Lab.Interfaces;

public class Program
{
    private static List<Persona> listaPersonas = new List<Persona>();
    public static void Main(string[] args)
    {
       
        Alumno alumno1 = new Alumno("0001", "Juarez", "Pablo","alumno1@gmailcom", "2022001", 15);
        Alumno alumno2 = new Alumno("0002", "Montufar", "Sebastian","alumno2@gmailcom", "2022002", 15);
        Alumno alumno3 = new Alumno("0003", "Vasquez", "Brandon","alumno3@gmailcom", "2022003", 15);
        Profesor profesor1 = new Profesor("0004","Tumax","Edwin","profesor1@gmail.com","3000268540101", "Profesor de matematícas");
        Profesor profesor2 = new Profesor("0005","Donis","Pedro","profesor1@gmail.com","3000268540101", "Profesor de Religión");
        
        Console.WriteLine("Centro Educativo Tecnico Laboral KINAL");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\t1 - Listado General");
        Console.WriteLine("\t2 - Registrar Asistencia");
        Console.WriteLine("\t3 - Operar Registro");
        Console.WriteLine("\t4 - Ver Mis Datos");
        Console.WriteLine("\t5 - Quitar Asignatura");
        Console.Write("Your option? ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("LISTADO GENERAL");
                ListadoGeneral(listaPersonas);



                break;
            case "2":
                Console.WriteLine($"REGISTRAR ASISTENCIA");
                RegistrarAsistencia(alumno1);
                RegistrarAsistencia(alumno2);
                RegistrarAsistencia(alumno3);
                RegistrarAsistencia(profesor1);
                RegistrarAsistencia(profesor2);
               

                break;
            case "3":
                Console.WriteLine($"OPERAR REGISTRO");
                OperarRegistro(alumno1);
                OperarRegistro(alumno2);
                OperarRegistro(alumno3);
                OperarRegistro(profesor1);

                break;
            case "4":
                Console.WriteLine($"VER MIS DATOS");
                VerMisDatos(alumno1);
                VerMisDatos(alumno2);
                VerMisDatos(alumno3);
                VerMisDatos(profesor1);

                break;
            case "5":
                Console.WriteLine("QUITAR ASIGNATURA");
                QuitarAsignatura(alumno1, "Biología");
                QuitarAsignatura(alumno3, "Sociales");
                break;
        }
        Console.Write("Press any key to close the Calculator console app...");
        Console.ReadKey();

        
    }

        private static void ListadoGeneral(List<Persona> listaPersonas)
    {
        Console.WriteLine($"Datos:");
        foreach (Alumno elemento in listaPersonas)
        {
             Console.WriteLine($"Datos {((Alumno)elemento).carne} {elemento.apellidos} {elemento.nombres}");
        }
         foreach (Profesor elemento in listaPersonas)
        {
             Console.WriteLine($"Datos {((Profesor)elemento).cui} {elemento.apellidos} {elemento.nombres}");
        }
        }
    private static void VerMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListasMisDatos(auxiliar.carne); 
            Console.WriteLine($"{elemento.nombres}");
        }else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListasMisDatos(auxiliar.cargo);
             Console.WriteLine($"{elemento.nombres}");
        }
        
    }
    static void RegistrarAsistencia(Persona elemento)
    {
        foreach (Persona registro in listaPersonas)
        {
            if (registro.uuid == elemento.uuid)
            {
                elemento.TomarAsistencia();
            }
        }
        Console.WriteLine($"Se ha registrado la asistencia de {elemento.nombres} ");
    }
    private static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((Ioperaciones)elemento).Eliminar(asignatura);
    }
    private static void OperarRegistro(Persona elemento)
    {
        listaPersonas.Add(elemento);
        Console.WriteLine($"Se ha operado el registro {elemento.nombres} ");
    }

    
    /*static void ImprimirInformacionGeneral(List<Persona> listaPersonas)
    {
        Console.WriteLine($"Información General");
        foreach (Persona elemento in listaPersonas)
        {
            if(elemento is Alumno)
            {
                Console.WriteLine($"Datos:{((Alumno)elemento).carne} {elemento.apellidos} {elemento.nombres}");
                Console.WriteLine("Registro de asistencia:");
                ((Alumno)elemento).TomarAsistencia();                
            }
            else if(elemento is Profesor)
            {
                Console.WriteLine($"Datos: {((Profesor)elemento).cargo} {elemento.apellidos} {elemento.nombres}");
                Console.WriteLine("Registro de asistencia:");
                ((Profesor)elemento).TomarAsistencia();                
            }           
        }
    }*/

}