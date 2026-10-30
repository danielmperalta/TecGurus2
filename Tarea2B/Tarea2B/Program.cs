namespace Tarea2B
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Realizar el cambio de una letra por otra, en una oración

            string? cad;
            char? letraActual, letraNueva;
            Console.Write("Escriba una frase: ");
            cad = Console.ReadLine();

            Console.Write("Letra a cambiar: ");
            letraActual = Convert.ToChar(Console.ReadLine());

            Console.Write("Por la letra: ");
            letraNueva = Convert.ToChar(Console.ReadLine());

            CadenaTexto cadenaTexto = new CadenaTexto(cad,letraActual, letraNueva);

            cadenaTexto.muestra(cadenaTexto);
            cadenaTexto.reemplaza();

        }
    }
}
