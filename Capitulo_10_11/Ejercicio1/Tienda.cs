using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_10_11.Ejercicio1
{
    class Tienda
    {
        public class Inventario
        {
            private int codigo;
            private string nombre;
            private int precio;

            public int Precio
            {
                get
                {
                    return precio;
                }
                set
                {
                    if(value <= 0)
                    {
                        precio = 1;
                    }
                    else
                    {
                        precio = value;
                    }
                }
            }
            public int Codigo
            {
                get
                {
                    return codigo;
                }
                set
                {
                    if (value <= 0)
                    {
                        codigo = 1;
                    }
                    else
                    {
                        codigo = value;
                    }
                }
            }
            public Inventario(int Codigo, string Nombre, int Precio)
            {
                codigo = Codigo;
                nombre = Nombre;
                precio = Precio;
            }
        }
    }
}
