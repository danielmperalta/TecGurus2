namespace Tarea2C
{
    public class Program
    {
        static void Main(string[] args)
        {

            // realiza un acronimo

            string? cad;
            Console.Write("Escriba un texto para generar su acronimo: ");
            cad = Convert.ToString(Console.ReadLine());

            CadenaTexto cadenaTexto = new CadenaTexto(cad);
            
            cadenaTexto.acronimo();
        }
    }
}
