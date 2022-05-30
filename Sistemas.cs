using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2C_EJemplo1_
{
    class Sistemas : Alumno
    {
        //variables globales para asignarles el valor del constructor
        char seccion;
        byte semestre;

        //Constructor de la clase Sistemas
        public Sistemas(char seccion, byte semestre, string nombre, string primerAllido,
           string segundoApellido, string curp, DateTime fechaNacimiento,
           DateTime fechaInscripcion)
            :base(nombre,primerAllido,segundoApellido,curp,fechaNacimiento,fechaInscripcion) {
            this.seccion = seccion;
            this.semestre = semestre;
        }
        public Sistemas(char seccion, byte semestre, string nombre, string primerAllido,
          string segundoApellido, string curp, DateTime fechaNacimiento,
          DateTime fechaInscripcion, char tipoSangree)
           : base(nombre, primerAllido, segundoApellido, curp, fechaNacimiento, 
                 fechaInscripcion, tipoSangree)
        {


        }

        public override void DetallesDePago()
        {
            base.DetallesDePago();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Seccion: {0}", seccion);
            Console.WriteLine("Semestre: {0}", semestre);
            Console.WriteLine("Ingeniería en Sistemas Computacionales");
            
        }

    }
}
