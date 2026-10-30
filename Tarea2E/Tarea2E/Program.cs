using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea2E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Firulais","caino","labrador",2,new DateTime(2024,8,5),"animal domestico",4,"cafe","casa");
            Pelicano pelicano = new Pelicano("Peli","ave","pelicano",10,new DateTime(2018,3,12),"vive cerca del hotel","amarillo","blanco");
            Ballena ballena = new Ballena("Balle","mamifero","ballena azul",15,new DateTime(2015,6,20),"le gusta el agua calida",2,"gris","oceano");

            Console.WriteLine("Fechas de cumpleaños y edades:");
            perro.cumpleanios();
            pelicano.cumpleanios();
            ballena.cumpleanios();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El habitat actual del perro es: " + perro.Habitat);
            Console.WriteLine("(la clase pelicano no cuenta con este dato)"); 
            //Console.WriteLine("El habitat actual del pelicano es:" + pelicano.Habitat);
            Console.WriteLine("El habitat actual de la ballena es: " + ballena.Habitat);
            Console.WriteLine("");
            Console.WriteLine("");



            if (perro.Edad >= pelicano.Edad && perro.Edad >= ballena.Edad)
            {
                Console.WriteLine("El perro es el animal de mayor edad");
            }
            else if (pelicano.Edad >= perro.Edad && pelicano.Edad >= ballena.Edad)
            {
                Console.WriteLine("El pelicano es el animal de mayor edad");
            }
            else
            {
                Console.WriteLine("La ballena es el animal de mayor edad");
            }

            if ((perro.Edad == pelicano.Edad) && (pelicano.Edad == ballena.Edad))
            {
                Console.WriteLine("Todos los animales tiene la misma edad");
            }


            Console.WriteLine("");


            if (perro.Edad <= pelicano.Edad && perro.Edad <= ballena.Edad)
            {
                Console.WriteLine("El perro es el animal de menor edad");
            }
            else if (pelicano.Edad <= perro.Edad && pelicano.Edad <= ballena.Edad)
            {
                Console.WriteLine("El pelicano es el animal de menor edad");
            }
            else
            {
                Console.WriteLine("La ballena es el animal de menor edad");
            }

            Console.WriteLine("");
            Console.WriteLine("Alimentacion:");
            perro.alimentacion();
            pelicano.alimentacion();
            ballena.alimentacion();
            Console.ReadKey();
        }
    }
}
