using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_10_11.Ejercicio2
{
    public class Ejercicio2
        {
            private string nombre;
            private int edad;
            private string direccion;
            private int promedio;

            public int Edad
            {
                get
                {
                    return edad;
                }
                set
                {
                    if(value <= 0)
                    {
                        edad = 1;
                    }
                    else
                    {
                        edad = value;
                    }
                }
            }
            public int Promedio
            {
                get
                {
                    return Promedio;
                }
                set
                {
                    if (value <= 0)
                    {
                        promedio = 1;
                    }
                    else
                    {
                        promedio = value;
                    }
                }
            }
            public Ejercicio2(string Nombre, int edad, string Direccion,int Promedio)
            {
                edad = Edad;
                promedio = Promedio;
                direccion = Direccion;
                nombre = Nombre;

            }
        }
    }

