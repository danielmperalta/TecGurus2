namespace Tarea2F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(12.5, 20.2);
            Circulo circulo = new Circulo(15.5);
            Triangulo triangulo = new Triangulo(18.5, 10.2);

            Console.WriteLine("");
            
            Console.WriteLine("Area del rectangulo es: " + Math.Round(rectangulo.area(), 2));
            Console.WriteLine("Area del circulo es: " + Math.Round(circulo.area(), 2));
            Console.WriteLine("Area del triangulo es: " + Math.Round(triangulo.area(), 2));
            
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
