using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2C_EJemplo1_
{
    class Program
    {
        public static void PersonalizaConsola() {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("RegistraTEC");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            #region OldCode
            //Calculadora objetoCalculadora = new Calculadora();
            ////Mediante el objeto puedo acceder a toos los miembos de la clase
            //objetoCalculadora.ValorUno = 100;            
            //int v1 = objetoCalculadora.ValorUno;
            //Console.WriteLine("El valor de la varibale es: {0}",v1);
            //Console.WriteLine(objetoCalculadora.SumarValores());            

            // //Instanciar la clase Alumno
            // Alumno objetoEduardo = new Alumno("Eeduardo","Gonzalez","Lozano","GLOE041201HCLRDL06", Convert.ToDateTime( "01-12-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
            // //objetoEduardo.Matricula = "211000132";
            // //objetoEduardo.Nombre = "Eduardo";
            // //objetoEduardo.FechaNacimiento = Convert.ToDateTime("01-12-2004 00:00:00");
            // //Instanciar la clase Alumno
            // Alumno objetoOmar = new Alumno("Gustavo Omar","Morillon","Rios", "GLOE041201HCLRDL06", Convert.ToDateTime("01-12-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
            //// objetoOmar.Matricula = "211000140";
            // //objetoOmar.Nombre = "Gustavo Omar";
            // //Instanciar la clase Alumno
            // Alumno objetoNairobi = new Alumno("Nairobi Alejandra","Garcia","Perez", "GLOE041201HCLRDL06", Convert.ToDateTime("01-12-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));
            // //objetoNairobi.Matricula = "211000141";
            // // objetoNairobi.Nombre = "Nairobi Alejandra";
            // //asigar al objetoNairobi la fecha de nacimiento
            // //objetoNairobi.FechaNacimiento = Convert.ToDateTime("26/02/1688 00:00:00");           

            // Alumno objetoNuevo = new Alumno("Brandon", "Zamora", "Lopez", "GLOE041201HCLRDL06", Convert.ToDateTime("01-01-2004 00:00:00"), Convert.ToDateTime("01-07-2021 00:00:00"));

            // //imprimir datos de los objetos
            // Console.WriteLine("Nombre del objeto: {0}", objetoEduardo.Nombre);
            // Console.WriteLine("Nombre del objeto: {0}", objetoOmar.Nombre);
            // Console.WriteLine("Nombre del objeto: {0}", objetoNairobi.Nombre);

            // Console.WriteLine("Edad del objeto: {0}", objetoNairobi.CalcularEdad1());
            // Console.WriteLine("Edad del objeto parametrizado: {0}", objetoNairobi.CalcularEdad2(Convert.ToDateTime("26-02-2003")));
            // Console.WriteLine("Fecha de nacimiento de objetoNairobi {0}", objetoNairobi.FechaNacimiento);


            // Console.Clear();
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine(objetoNairobi.CalcularEdad());
            // Console.WriteLine(objetoEduardo.CalcularEdad());
            // Console.WriteLine(objetoOmar.CalcularEdad());
            // Console.WriteLine(objetoNuevo.CalcularEdad());


            // Console.WriteLine( objetoOmar.CalificacionAlumno(90, 100, 90));

            // Console.WriteLine("\n");
            // Console.WriteLine("\n");
            // Console.WriteLine( objetoOmar.MuestraInformacionDelAlumno());
            // Console.WriteLine("Vamos a obtener el pago de {0}", objetoOmar.Nombre.ToUpper());
            // Console.WriteLine("\n");
            // Console.WriteLine(objetoOmar.CalcularPagoInscripcion(79));
            // Console.WriteLine(objetoOmar.DetallesDePago(79));

            // Console.WriteLine("\n");
            // Console.WriteLine("\n");
            // objetoNairobi.DetallesDePago();

            #endregion
            Program.PersonalizaConsola();
            string nombre, primerAllido, segundoApellido, curp;
            DateTime fechaNacimiento, fechaInscripcion;
            Console.WriteLine("Ingresa el nombre del alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el primer Apelllido");
            primerAllido = Console.ReadLine();
            Console.WriteLine("Ingresa el nsegundo Apellido");
            segundoApellido = Console.ReadLine();
            Console.WriteLine("Ingresa la CURP del alumno");
            curp = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento del alumno");
            fechaNacimiento = Convert.ToDateTime(Console.ReadLine());

            fechaInscripcion = DateTime.Now;


            Sistemas alumnoSistemas = new Sistemas('C', 2, nombre, primerAllido, segundoApellido, curp, fechaNacimiento, fechaInscripcion);
            alumnoSistemas.DetallesDePago();
            alumnoSistemas.PromedioMateria();



            //Arreglos Uniodimensionales
            Console.WriteLine("Uso de arreglos");
            Console.WriteLine("\n");
            //Declarar un arreglo
            string[] alumnos2C = new string[11];
            alumnos2C[0] = "Daniel";
            alumnos2C[1] = "Cuahutemoc";
            alumnos2C[2] = "Omar";
            alumnos2C[3] = "Erika";
            alumnos2C[4] = "Jesse";
            alumnos2C[5] = "Miguel";
            alumnos2C[6] = "Eduardo";
            alumnos2C[7] = "Nairobi";
            alumnos2C[8] = "Valeria";
            alumnos2C[9] = "Daniela";

            //REcorrer arreglos
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(alumnos2C[i]);
            //}
           
            //Segunda opcion de recorrer el arreglo
            foreach (string resultado in alumnos2C)
            {
               
                Console.WriteLine(resultado);
                
            }


            //Console.WriteLine(alumnos2C[0]);
            //Console.WriteLine(alumnos2C[1]);
            //Console.WriteLine(alumnos2C[2]);
            //Console.WriteLine(alumnos2C[3]);
            //Console.WriteLine(alumnos2C[4]);
            //Console.WriteLine(alumnos2C[5]);
            //Console.WriteLine(alumnos2C[6]);
            //Console.WriteLine(alumnos2C[7]);
            //Console.WriteLine(alumnos2C[8]);
            //Console.WriteLine(alumnos2C[9]);

            Console.ReadKey();
        }
    }
}
