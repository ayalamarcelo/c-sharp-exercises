class Program
{
    /*
    Trabajas en una ONG y necesitas registrar la información de los voluntarios. El registro incluye el 
    código de voluntario (numérico), nombre, tipo de actividad (como código: 1 para actividades sociales, 
    2 para actividades ambientales, 3 para actividades educativas), horas trabajadas en el último mes, y 
    año de ingreso a la ONG.

    1) Verifica que el tipo de actividad sea válido (1, 2 o 3).
    2) Informa por cada voluntario: nombre, tipo de actividad, horas trabajadas y año de ingreso.
    3) Calcula el total de horas trabajadas por todos los voluntarios e infórmalo al finalizar.
    4) Informa cuántos voluntarios ingresaron antes del año 2017.
    5) Determina el voluntario con más horas trabajadas y muestra su nombre, tipo de actividad y 
    cantidad de horas.
    */

    public static void Main(string[] args)
    {
        int codigoVoluntario = 0;
        int cantidadVoluntarios = 0;
        int actividad = 0;
        int horasTrabajadas = 0;
        int totalHoras = 0;
        int anioIngreso = 0;
        int anioIngreso2017 = 0;

        int voluntarioHoras = 0;
        string voluntarioNombre = " ";
        int voluntarioActividad = 0;

        string nombre = "";
        bool continuar = true;

        do
        {
            Console.WriteLine("Ingrese su nombre o (* para salir)\n");
            nombre = Console.ReadLine();
            if (nombre.ToLower().Equals("*"))
            {
                Console.WriteLine("Adios...!");
                break;
            }

            Console.WriteLine("Ingrese su código de voluntario");
            codigoVoluntario = int.Parse(Console.ReadLine());
            cantidadVoluntarios++;

            Console.WriteLine("Ingrese tipo de actividad que realiza como voluntario\n");
            actividad = int.Parse(Console.ReadLine());

            while (actividad < 1 || actividad > 3)
            {
                switch (actividad)
                {
                    case 1:
                        Console.WriteLine("1. Actividades Sociales");
                        break;
                    case 2:
                        Console.WriteLine("2. Actividades Ambientales");
                        break;
                    case 3:
                        Console.WriteLine("3. Actividades Educativas");
                        break;
                    case 0:
                    default:
                        Console.WriteLine("Ingrese tipo de actividad que realiza como voluntario");
                        actividad = int.Parse(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Ingrese la cantidad de horas trabajadas durante el mes");
            horasTrabajadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año de ingreso como voluntario");
            anioIngreso = int.Parse(Console.ReadLine());

            Console.WriteLine($"Datos del voluntario: Nombre: {nombre}, Tipo de actividad que realiza: {actividad}, Horas trabajadas: {horasTrabajadas}, Año de ingreso: {anioIngreso}");

            if (horasTrabajadas > totalHoras)
            {
                totalHoras += horasTrabajadas;
            }

            if(anioIngreso < 2017){
                anioIngreso2017++;
            }

            if(horasTrabajadas > voluntarioHoras) {
                voluntarioHoras = horasTrabajadas;
                voluntarioNombre = nombre;
                voluntarioActividad = actividad;
            }

        } while (continuar);

        Console.WriteLine($"Datos del voluntario con más horas trabajadas: Nombre: {voluntarioNombre}, Tipo Actividad: {voluntarioActividad}, Horas: {voluntarioHoras}");
        Console.WriteLine($"Cantidad de horas trabajadas por todos los voluntarios: {totalHoras}");
    }
}