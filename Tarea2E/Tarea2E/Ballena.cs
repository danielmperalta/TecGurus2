using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2E
{
    public class Ballena : Animal
    {
        private int cantidadAletas;
        private string colorPiel;
        private string habitat;

        public int CantidadAletas { get => cantidadAletas; set => cantidadAletas = value; }
        public string ColorPiel { get => colorPiel; set => colorPiel = value; }
        public string Habitat { get => this.habitat; set => this.habitat = value; }

        public Ballena(string nombre, string especie, string raza,int edad, DateTime fechaNacimiento,string observaciones,int cantidadAletas,string colorPiel,string habitat) : base(nombre,especie,raza,edad,fechaNacimiento,observaciones)
        {
            CantidadAletas = cantidadAletas;
            ColorPiel = colorPiel;
            Habitat = habitat;
        }

        public override void cumpleanios()
        {
            Console.WriteLine("La ballena nacio el dia:{0} y tiene {1} años ", FechaNacimiento.ToString("dd/MM/yyyy"), Edad);
        }

        public override void alimentacion()
        {
            Console.WriteLine("La ballena se alimenta principalmente de organismos pequeños");
        }


    }
}
