﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2C_EJemplo1_
{
    class Alumno
    {
        #region Variables
        //Declarar los mimebros de tipo campo
        string matricula, contrasena = "123456", carrera;
        string nombre, primerAllido, segundoApellido, curp;
        DateTime fechaNacimiento, fechaInscripcion; //Tipo de dato No Primitivo        
        char seccion, semestre;
        bool acceso = false;
        private char tipoSangre;
        //Miembro de tipo constante
        const string NUMERO_TECNOLIGICO = "100";

        #endregion

        #region Construcores
        //Miembro de tipo Contructor
        // Tipo de acceso nombre del contructor(clase)  (entrada){}
        public Alumno(string nombre, string primerAllido,
            string segundoApellido, string curp, DateTime fechaNacimiento,
            DateTime fechaInscripcion, char tipoSangre)
        {
            this.nombre = nombre;
            this.primerAllido = primerAllido;
            this.segundoApellido = segundoApellido;
            this.curp = curp;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaInscripcion = fechaInscripcion;
            //Sea creada la matricula
            this.matricula = fechaInscripcion.Year + "" + NUMERO_TECNOLIGICO;
        }
        //Sobrerecarga
        public Alumno()
        {
        }
        public Alumno(string nombre, string primerAllido,
           string segundoApellido, string curp, DateTime fechaNacimiento,
           DateTime fechaInscripcion)
        {
            this.nombre = nombre;
            this.primerAllido = primerAllido;
            this.segundoApellido = segundoApellido;
            this.curp = curp;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaInscripcion = fechaInscripcion;
            //Sea creada la matricula
            //Anexar a matricula el valor de la clase static
            //Camino largo
            if (Folio.numeroFolio >= 1 && Folio.numeroFolio <= 9)
            {
                this.matricula = (fechaInscripcion.Year + "" + NUMERO_TECNOLIGICO).Substring(2, 5) + "000" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 10 && Folio.numeroFolio <= 99)
            {
                this.matricula = (fechaInscripcion.Year + "" + NUMERO_TECNOLIGICO).Substring(2, 5) + "00" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 100)
            {
                this.matricula = (fechaInscripcion.Year + "" + NUMERO_TECNOLIGICO).Substring(2, 5) + "0" + Folio.numeroFolio;
            }
            Folio.numeroFolio = Folio.numeroFolio + 1;
        }

        #endregion

        #region Propiedades
        //Agregar un miembro de tipo propiedad
        public string Contrasena
        {
            //get |  set
            get
            {
                return contrasena;
            }
        }
        public string Matricula
        {
            get { return matricula; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Acceso
        {
            get { return acceso; }
            set { acceso = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        #endregion

        #region Metodos

        //Agregar un miebro de timpo Metodo
        //tipoDeAcceso tipoDato nombre (opcionmalmente params){}
        //tipo: public | private | protected   | internal
        //string | int | bool | double | char | float | smallint
        public string CalcularEdad()
        {
            //validar si se cargo la fecha de nacimeinto de mi objeto
            int edad;
            string valorDeRetornoDeLaFuncion;
            //si no if else
            if (fechaNacimiento.Year <= 1800)
            {
                //Tarea: la variable valorDeRetornoDeLaFuncion debe regreresar une
                //string.Format en que debe imprimir el nombre del alumno
                valorDeRetornoDeLaFuncion = "El alumno tiene una Fecha no asignada";
            }
            else
            {
                edad = (DateTime.Now - fechaNacimiento).Days / 365;
                valorDeRetornoDeLaFuncion =
                    string.Format("La edad del alumno con matricula: {3} {0} {2}, es de {1}, años.",
                       nombre, edad.ToString(), primerAllido, matricula);
            }

            //determinar la salida de la funcion
            //return edad.ToString();
            return valorDeRetornoDeLaFuncion;
        }

        //Nuevo metodo
        public byte CalcularEdad1()
        {
            //validar si se cargo la fecha de nacimeinto de mi objeto
            int edad;
            edad = (DateTime.Now - fechaNacimiento).Days / 365;
            //si no if else
            if (edad >= 100)
            {
                //Tarea: la variable valorDeRetornoDeLaFuncion debe regreresar une
                //string.Format en que debe imprimir el nombre del alumno
                edad = 0;
            }
            //determinar la salida de la funcion
            //return edad.ToString();
            return Convert.ToByte(edad);
        }


        /*
            Metodo con valores de entrada (dominmio)
            los valores de entrada en programacion se comocen 
            como parametros (params)
         */
        public byte CalcularEdad2(DateTime fechaNacimientoParam)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            fechaNacimiento = fechaNacimientoParam;
            //validar si se cargo la fecha de nacimeinto de mi objeto
            int edad;
            edad = (DateTime.Now - fechaNacimientoParam).Days / 365;
            //si no if else
            if (edad >= 100)
            {
                //Tarea: la variable valorDeRetornoDeLaFuncion debe regreresar une
                //string.Format en que debe imprimir el nombre del alumno
                edad = 0;
            }
            //determinar la salida de la funcion
            //return edad.ToString();
            return Convert.ToByte(edad);

        }

        //metodo calificacion de prueba
        public byte CalificacionAlumno(byte calif1, byte calif2, byte calif3)
        {
            int x;
            return Convert.ToByte((calif1 + calif2 + calif3) / 3);
        }

        //Imprimir en consolael nombrre del aluimno
        public string MuestraInformacionDelAlumno() {
            string valorDeRetorno = this.matricula + " " + this.nombre + " " + this.primerAllido;            
            return valorDeRetorno.ToUpper();
        }

        //Metodo para calcular descuentos en el pago de la inscripcion
        public double CalcularPagoInscripcion( int promedio  )/*97 */ {
            double valorDeRetorno = 2700;

            //Validar para saber en que rango esta el promedio
            if (promedio >= 95)
            {
                valorDeRetorno -= 2000; //700
                return valorDeRetorno;
            }
            if (promedio >= 80)
            {
                valorDeRetorno -= 700; //2000
                return valorDeRetorno;
            }
            return valorDeRetorno;
        } //43.23


        //Metodo para informacion de pago
        public string DetallesDePago(int promedio) {

            string valorDeRetorno;

            //valorDeRetorno = "Datos de Pago: \n" +  "Matricula: " 
            //    +  matricula +" \n "+  "Nombre: " + nombre + primerAllido 
            //    +" \n"+ "Total a pagar: " + CalcularPagoInscripcion(90) 
            //    +"\n"+ "Becado: "  ;            

            if (promedio >= 80)
            {
                valorDeRetorno = string.Format("Datos de Pago: \n Matricula: {0} \n Nombre: {1} " +
                "\n Total a pagar: {2} \n Becado: SI",
                matricula, nombre, CalcularPagoInscripcion(promedio));
            }
            else
            {
                valorDeRetorno = string.Format("Datos de Pago: \n Matricula: {0} \n Nombre: {1} " +
                "\n Total a pagar: {2} \n Becado: NO",
                matricula, nombre, CalcularPagoInscripcion(promedio));
            }           
            return valorDeRetorno;
        }

        #endregion


    }
}