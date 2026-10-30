using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2E
{
    public class Perro : Animal
    {
        private int cantidadPatas;
        private string colorPelaje;
        private string habitat;


        public int CantidadPatas { get => cantidadPatas; set => cantidadPatas = value; }
        public string ColorPelaje { get => colorPelaje; set => colorPelaje = value; }
        public string Habitat { get => habitat; set => habitat = value; }

        public Perro(string nombre, string especie, string raza, int edad,DateTime fechaNacimiento, string observaciones,int cantidadPatas, string colorPelaje,string habitat) : base(nombre, especie, raza, edad, fechaNacimiento, observaciones)
        {
            CantidadPatas = cantidadPatas;
            ColorPelaje = colorPelaje;
            Habitat = habitat;
        }

        public override void cumpleanios()
        {
            Console.WriteLine("cumpleaños");
        }

        public override void alimentacion()
        {
            Console.WriteLine("croquetas");
        }

    }

}
