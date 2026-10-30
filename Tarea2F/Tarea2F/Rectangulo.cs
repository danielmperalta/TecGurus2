using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2F
{
    internal class Rectangulo : IForma
    {
        private double lado1;
        private double lado2;

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
        
        
        public Rectangulo(double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }
        
        public double area()
        {
            return lado1 * lado2;
        }
    }
}
