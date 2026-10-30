using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2B
{
    public class CadenaTexto
    {
        private string cadena = string.Empty;
        private char letraO;
        private char letraN;

        public string Cadena { get => cadena; set => cadena = value; }
        public char LetraO { get => letraO; set => letraO = value; }
        public char LetraN { get => letraN; set => letraN = value; }


        public CadenaTexto(string? cadena, char? letraO, char? letraN)
        {
            this.cadena = cadena;
            this.LetraO = Convert.ToChar(letraO);
            this.LetraN = Convert.ToChar(letraN);
        }

        public void muestra(CadenaTexto cadenaTexto)
        {
            Console.WriteLine();
            Console.WriteLine($""""
                La cadena original es: {cadenaTexto.cadena}
                Se buscara la letra: {cadenaTexto.letraO}
                Y se reemplazara por: {cadenaTexto.letraN}
                """");
            Console.WriteLine();
        }


        public virtual void reemplaza()
        {
            Console.WriteLine("Cadena con los caracteres reemplazados:");

            string resultado = cadena.Replace(letraO, letraN);

            Console.WriteLine(resultado);

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
