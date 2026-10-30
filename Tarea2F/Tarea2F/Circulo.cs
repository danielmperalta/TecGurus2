using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2F
{
    internal class Circulo : IForma
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        
        public Circulo(double radio) 
        {
            Radio = radio;
        }

        public double area()
        {
            return Math.PI * radio * radio;
        }
    }
}
