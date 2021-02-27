using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_10_11.Ejercicio3
{
    class Poligono
    {
        private int lados;
        private int circunferencia;
        private int apotema;

        public int Lados
        {
            get
            {
                return lados;
            }
            set
            {
                if (value <= 0)
                {
                    lados = 1;
                }
                else
                {
                    lados = value;
                }
            }
        }
        public int Circunferencia
        {
            get
            {
                return circunferencia;
            }
            set
            {
                if(value <= 0)
                {
                    lados = 1;
                }
                else
                {
                    circunferencia = value;
                }
            }
        }
        public int Apotema
        {
            get
            {
                return apotema;
            }
            set
            {
                if(value <= 0)
                {
                    apotema = 1;
                }
                else
                {
                    apotema = value;
                }
            }
        }
        public Poligono()
        {
            this.lados = Lados;
            this.circunferencia = Circunferencia;
            this.apotema = Apotema;
        }
        public Poligono(int circunferencia, int apotema)
        {
            this.circunferencia = Circunferencia;
            this.apotema = Apotema;

        }
        public Poligono(int Lados, int Circunferencia, int Apotema)
        {
            lados = Lados;
            circunferencia = Circunferencia;
            apotema = Apotema;
         }
    }
}
