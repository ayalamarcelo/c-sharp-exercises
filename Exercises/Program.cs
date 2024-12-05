using System.Collections;
using System.Net.Sockets;
using System.Reflection;

class Program
{ /* Practicando "Struct" */

    /* Struct: Tipo de dato compuesto por otros*/
    struct fechaNacimiento
    {
        public int dia;
        public int mes;
        public int anio;
    }

    struct tipoPersona
    {
        public string nombre;
        public char inicial;
        public fechaNacimiento diaDeNacimiento;
        public float nota;
    }

    public static void Main(string[] args)
    {
        // Declaración de la variable del tipo estructura
        tipoPersona persona;
      
        // Inicialización de los campos
        persona.nombre = "Juan";
        persona.inicial = 'J';
        persona.diaDeNacimiento.dia = 15;
        persona.diaDeNacimiento.mes = 9;
        persona.diaDeNacimiento.anio = 1998;
        persona.nota = 7;

        // Infrome
        Console.WriteLine("{0} nació el dia {1}", persona.nombre, persona.diaDeNacimiento.dia);


    }

}