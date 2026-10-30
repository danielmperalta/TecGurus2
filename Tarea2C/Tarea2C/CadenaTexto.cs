using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2C
{
    public class CadenaTexto
    {

        private string cadena = string.Empty;

        public string Cadena { get => cadena; set => cadena = value; }


        public CadenaTexto(string cadena)
        {
            this.cadena = cadena.ToUpper();
        }

        public virtual void acronimo()
        {
            Console.WriteLine();
            Console.WriteLine("Texto convertido en acronimo:");

            string[] arreglo = cadena.Split(" ");

            for (int i= 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i].Substring(0,1) + ".");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
