using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2C_EJemplo1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora objetoCalculadora = new Calculadora();
            ////Mediante el objeto puedo acceder a toos los miembos de la clase
            //objetoCalculadora.ValorUno = 100;            
            //int v1 = objetoCalculadora.ValorUno;
            //Console.WriteLine("El valor de la varibale es: {0}",v1);
            //Console.WriteLine(objetoCalculadora.SumarValores());            

            //Instanciar la clase Alumno
            Alumno objetoEduardo = new Alumno("Eeduardo","Gonzalez","Lozano","GLOE041201HCLRDL06", Convert.ToDateTime( "01-12-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
            //objetoEduardo.Matricula = "211000132";
            //objetoEduardo.Nombre = "Eduardo";
            //objetoEduardo.FechaNacimiento = Convert.ToDateTime("01-12-2004 00:00:00");
            //Instanciar la clase Alumno
            Alumno objetoOmar = new Alumno("Gustavo Omar","Morillon","Rios", "GLOE041201HCLRDL06", Convert.ToDateTime("01-12-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
           // objetoOmar.Matricula = "211000140";
            //objetoOmar.Nombre = "Gustavo Omar";
            //Instanciar la clase Alumno
            Alumno objetoNairobi = new Alumno("Nairobi Alejandra","Garcia","Perez", "GLOE041201HCLRDL06", Convert.ToDateTime("01-12-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
            //objetoNairobi.Matricula = "211000141";
            // objetoNairobi.Nombre = "Nairobi Alejandra";
            //asigar al objetoNairobi la fecha de nacimiento
            //objetoNairobi.FechaNacimiento = Convert.ToDateTime("26/02/1688 00:00:00");           

            Alumno objetoNuevo = new Alumno("Brandon", "Zamora", "Lopez", "GLOE041201HCLRDL06", Convert.ToDateTime("01-01-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
           
            //imprimir datos de los objetos
            Console.WriteLine("Nombre del objeto: {0}", objetoEduardo.Nombre);
            Console.WriteLine("Nombre del objeto: {0}", objetoOmar.Nombre);
            Console.WriteLine("Nombre del objeto: {0}", objetoNairobi.Nombre);

            Console.WriteLine("Edad del objeto: {0}", objetoNairobi.CalcularEdad1());
            Console.WriteLine("Edad del objeto parametrizado: {0}", objetoNairobi.CalcularEdad2(Convert.ToDateTime("26-02-2003")));
            Console.WriteLine("Fecha de nacimiento de objetoNairobi {0}", objetoNairobi.FechaNacimiento);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(objetoNairobi.CalcularEdad());
            Console.WriteLine(objetoEduardo.CalcularEdad());
            Console.WriteLine(objetoOmar.CalcularEdad());
            Console.WriteLine(objetoNuevo.CalcularEdad());


            Console.WriteLine( objetoOmar.CalificacionAlumno(90, 100, 90));

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine( objetoOmar.MuestraInformacionDelAlumno());
            Console.WriteLine("Vamos a obtener el pago de {0}", objetoOmar.Nombre.ToUpper());
            Console.WriteLine("\n");
            Console.WriteLine(objetoOmar.CalcularPagoInscripcion(79));
            Console.WriteLine(objetoOmar.DetallesDePago(79));
            Console.ReadKey();
        }
    }
}
