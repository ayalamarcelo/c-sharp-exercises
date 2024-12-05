using System.Collections;
using System.Net.Sockets;

class Program
{ /* Practicando "Struct" */

 /* Struct: Tipo de dato compuesto por otros*/
    struct tipoPersona {
        public string nombre;
        public char inicial;
        public int edad;
        public float nota;
    }

    public static void Main(string[] args){
       tipoPersona persona;

       persona.nombre = "Marcelo";
       persona.inicial = 'M';
       persona.edad = 34;
       persona.nota = 8;

       Console.WriteLine($"La edad de {persona.nombre} es {persona.edad}");
    }
    
}