namespace Tarea2A
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dada una cadena invertir el orden de aparición de sus palabras.
            
            //CadenaTexto cadenaTexto = new CadenaTexto("este es un mensaje de prueba para POO");

            string? cad;
            Console.Write("Escriba una frase: ");
            cad = Convert.ToString(Console.ReadLine());

            CadenaTexto cadenaTexto = new CadenaTexto(cad);

            cadenaTexto.muestra(cadenaTexto);
            cadenaTexto.invierteCadena();

        }
    }
}
