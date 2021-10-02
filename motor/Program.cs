using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Motor
    {
        private string tipo;
        private double potencia;

        public double Potencia
        {
            get
            {
                return Potencia;
            }
            set
            {
                potencia = value;
            }
        }


        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public Motor()
        {
            tipo = "";
            potencia = 0.0;
        }
        public Motor(string tipo, double potencia)
        {
            this.tipo = tipo;
            this.potencia = potencia;
        }

        public override string ToString()
        {
            return base.ToString() + "--> tipo:" + "potencias" + potencia;
        }



    
}


    

