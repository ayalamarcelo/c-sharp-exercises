class Program
{
    /*
    Imagina que trabajas en una empresa y necesitas llevar un registro de empleados. 
    Tienes un listado con el código de empleado (numérico), nombre, departamento 
    (como código: 1 para ventas, 2 para marketing, 3 para finanzas, 4 para recursos humanos), 
    edad y año de contratación.
    Verifica que el código de departamento sea válido (debe ser entre 1 y 4).
    Informa por cada empleado: nombre, departamento, edad y año de contratación.
    Calcula el promedio de edad de todos los empleados e infórmalo al finalizar.
    Calcula e informa cuántos empleados fueron contratados antes del año 2010.
    Determina el empleado de mayor edad e informa su nombre, departamento y edad.
    */

    public static void Main(string[] args)
    {
        int departamento = 0;
        int edad = 0;
        int cantidad = 0;
        int edadTotal = 0;
        int promedio = 0;
        int anioContratacion = 0;
        int contratoAnterior = 0;
        int empleadoMayorEdad = 0;
        int deptoEmpleadoMayorEdad = 0;

        string nombre = " ";
        string nombreEmpleadoMayorEdad = " ";
        bool continuar = false;

        do
        {
            Console.WriteLine("Ingrese su código de empleado (0 para salir)");
            int codigo = int.Parse(Console.ReadLine());
            if (codigo != 0)
            {
                continuar = true;
            }
            else
            {
                Console.WriteLine("Estás saliendo...");
                break;
            }


            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el código de su departamento: ");
            departamento = int.Parse(Console.ReadLine());

            //Validación de código de departamento

            while(departamento < 1 || departamento > 4){
                Console.WriteLine("Ingrese un código válido");
                departamento = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if(edad > 0){
                edadTotal += edad;
                cantidad++;
            }

            Console.WriteLine("Ingrese su año de contratación: ");
            anioContratacion = int.Parse(Console.ReadLine());

            Console.WriteLine($"::: Datos del empleado: Nombre: {nombre}, Departamento: {departamento}, Edad: {edad}, Año de Contratación: {anioContratacion} :::");
        
            if(anioContratacion < 2010) {
              contratoAnterior++;
            }

            // Empleado de mayor edad
            if(edad > empleadoMayorEdad){
                nombreEmpleadoMayorEdad = nombre;
                empleadoMayorEdad = edad;
                deptoEmpleadoMayorEdad = departamento;
            }

            // Promedio
            promedio = edadTotal / cantidad;


        } while (continuar);

        Console.WriteLine($"Datos del empleado de mayor edad: Nombre: {nombreEmpleadoMayorEdad}, Edad: {empleadoMayorEdad}, Departamento: {deptoEmpleadoMayorEdad}");
        Console.WriteLine($"Cantidad de empleados contratados antes del 2010: {contratoAnterior}");
        Console.WriteLine($"El promedio de edad de todos los empleaodos es {promedio}");
    }
}