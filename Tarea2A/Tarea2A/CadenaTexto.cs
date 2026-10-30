using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2A
{
    public class CadenaTexto
    {
        private string cadena = string.Empty;

        public string Cadena { get => cadena; set => cadena = value; }

       
        public CadenaTexto(string cadena)
        {
            this.cadena = cadena;
        }

        public void muestra(CadenaTexto cadenaTexto)
        {
            Console.WriteLine();
            Console.WriteLine($""""
                La cadena original es:
                {cadenaTexto.cadena}
                """");
            Console.WriteLine();
        }

        public virtual void invierteCadena()
        {
            Console.WriteLine("Invirtiendo el orden de las palabras:");

            string[] arreglo = cadena.Split(" ");

            for (int i = arreglo.Length - 1; i >= 0; i--)
            {
                Console.Write(arreglo[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
