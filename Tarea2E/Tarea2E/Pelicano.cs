using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2E
{
    public class Pelicano:Animal
    {
        private string colorPico;
        private string colorPlumas;

        public string ColorPico { get => colorPico; set => colorPico = value; }
        public string ColorPlumas { get => colorPlumas; set => colorPlumas = value; }


        public Pelicano(string nombre, string especie, string raza, int edad, DateTime fechaNacimiento, string observaciones,string colorPico,string colorPlumas ) : base(nombre, especie, raza, edad, fechaNacimiento, observaciones)
        {
            ColorPico = colorPico;
            ColorPlumas = colorPlumas;

        }

        public override void cumpleanios()
        {
            Console.WriteLine("El pelicano nacio el dia:{0} y tiene {1} años ", FechaNacimiento.ToString("dd/MM/yyyy"), Edad );
            
        }

        public override void alimentacion()
        {
            Console.WriteLine("El pelicano se alimenta principalmente de peces");
        }
    }
}
