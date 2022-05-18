using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2C_EJemplo1_
{
    class Calculadora
    {
        //Declaracion de variables (CAMPOS
        //| ATRIBUTOS)
        int valorUno = 20, valorDos = 10;
        //DEclaracion de una constante (MIEMBRO)
        const double pi = 3.14;
        //Declarar una PROPIEDAD (MIEMBRO)
        //public tipoDeAto nombrePropiedad
        public int ValorUno
        {
            set {
                valorUno = value;
            }
            get
            {
                return valorUno;
            }
            //set(estalecer | escribir)  get(obtener | leer)
        }
        public int LeerValorUno {
            get
            {
                return valorUno;
            }
        }
        public int EscribirEnNumeroUno {
            set
            {
                valorUno = value;
            }
        }


        //Pedir los datoa para valorUno
        //Defionir un metodo (acción)
        //public | string, int, double, float, char, bool, smaillint | nombre del metodo (){}
        public int SumarValores()
        {
            return valorUno + valorDos;
        }
    }
}
