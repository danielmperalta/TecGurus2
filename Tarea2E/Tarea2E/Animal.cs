using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2E
{
    public abstract class Animal
    {
        private string nombre;
        private string especie;
        private string raza;
        private int edad;
        private DateTime fechaNacimiento;
        private string observaciones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }

        //public int Edad { get => edad; set => edad = value; }
        public int Edad { get { int edadCalculada = DateTime.Today.Year - FechaNacimiento.Year; return edadCalculada; } } 
        
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }


        public Animal(string nombre, string especie, string raza, int edad,DateTime fechaNacimiento,string observaciones)
        {
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            //Edad = edad;
            FechaNacimiento = fechaNacimiento;
            Observaciones = observaciones;
        }

        public abstract void cumpleanios();
        

        public abstract void alimentacion();
    }
}
