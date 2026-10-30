namespace Tarea2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asignamos valores
            Profesional profesional = new Profesional(new DateTime(2020, 11, 01), 12345, "A123", "Juan", "Perez", "Hernandez", "Monterrey NL");
            Medico medico = new Medico(new DateTime(2019, 01, 05), 24680, "UNAM", "Pedro", "Jimenez", "Perez", "CDMX","HOSPITAL A",100,50,10);
            Abogado abogado = new Abogado(new DateTime(2010, 05, 08), 1357, "UNAM", "Jesus", "Garcia", "Hernandez", "Guadalajara Jal", "01-TC05-MX", 10, 45);

            //Mostramos todos los datos profesionales y los del ejercicio de su carrera
            profesional.muestraDatosProfesional(profesional);

            medico.muestraDatosProfesional(medico);
            medico.muestraDatosMedico();

            abogado.muestraDatosProfesional(abogado);
            abogado.muestraDatosAbogado();

            //calculamos la antiguedad
            profesional.aniversario();
            medico.aniversario();
            abogado.aniversario();


            // verifico que traiga la antiguedad correcta
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Los años de experiencia son:");
            Console.Write("Para el profesional:");
            Console.WriteLine("{0} años", profesional.Antiguedad);

            Console.Write("Para el medico:");
            Console.WriteLine("{0} años", medico.Antiguedad);

            Console.Write("Para el abogado:");
            Console.WriteLine("{0} años", abogado.Antiguedad);

            Console.WriteLine();
            Console.WriteLine("------comparando años de experiencia ----------------------");
            Console.WriteLine();


            //comparamos para ver quien tiene mas años de experiencia si el MEDICO o el ABOGADO
            if (medico.Antiguedad > abogado.Antiguedad)
            {
                Console.WriteLine("El MEDICO tiene MAS experiencia que el ABOGADO");
                Console.Write("Experiencia:");
                Console.WriteLine("{0} años", medico.Antiguedad);//medico.aniversario();
                medico.muestraDatosProfesional(medico);
                //medico.muestraDatosMedico();
                
            }
            else if (medico.Antiguedad < abogado.Antiguedad)
            {
                Console.WriteLine("El ABOGADO tiene MAS experiencia que el MEDICO");
                Console.Write("Experiencia:");
                Console.WriteLine("{0} años", abogado.Antiguedad);
                abogado.muestraDatosProfesional(abogado);
                abogado.muestraDatosAbogado();
            }
            else
            {
                Console.WriteLine("El ABOGADO tiene la MISMA experiencia que el MEDICO");

                Console.Write("Experiencia:");
                Console.WriteLine("{0} años", abogado.Antiguedad);
                abogado.muestraDatosProfesional(abogado);
                //abogado.muestraDatosAbogado();

                Console.Write("Experiencia:");
                Console.WriteLine("{0} años", medico.Antiguedad);
                medico.muestraDatosProfesional(medico);
                //medico.muestraDatosMedico();
            }

            Console.WriteLine();
            Console.WriteLine("------comparando donde estudiaron ----------------------");
            Console.WriteLine();

            //verificamos si estudiaron en la misma UNIVERSIDAD o diferentee
            if (medico.CedulaIdentidad == abogado.CedulaIdentidad)
            {
                Console.WriteLine("Los dos profesionales egresaron de la misma universidad");
            }
            else
            {
                Console.WriteLine("Los dos profesionales egresaron de universidades diferentes");
            }


            Console.WriteLine();
            Console.WriteLine("------comparando donde viven ----------------------");
            Console.WriteLine();

            //verificamos si viven en la misma ZONA o diferentee
            if (medico.Direccion == abogado.Direccion)
            {
                Console.WriteLine("Los dos profesionales viven  en la misma zona");
            }
            else
            {
                Console.WriteLine("Los dos profesionales viven en zonas diferentes");
            }


            Console.WriteLine();
            Console.WriteLine("------cuantos juicios en proceso tiene el abogado? ----------------------");
            Console.WriteLine("Actualmente el abogado cuenta con {0} juicios en proceso", abogado.NroJuiciosProceso);
        }

    }
}
