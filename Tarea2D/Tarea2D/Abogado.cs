using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2D
{
    public class Abogado: Profesional
    {
        private string nombreJuzgado;
        private int nroJuiciosProceso;
        private long nroJuiciosFinalizado;

        public string NombreJuzgado { get => nombreJuzgado; set => nombreJuzgado = value; }
        public int NroJuiciosProceso { get => nroJuiciosProceso; set => nroJuiciosProceso = value; }
        public long NroJuiciosFinalizado { get => nroJuiciosFinalizado; set => nroJuiciosFinalizado = value; }

        public Abogado(DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion, string nombreJuzgado, int nroJuiciosProceso, long nroJuiciosFinalizado) : base(fechaEgreso, nroTituloAcademico, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion)
        {
            this.nombreJuzgado = nombreJuzgado;
            this.nroJuiciosProceso = nroJuiciosProceso;
            this.nroJuiciosFinalizado = nroJuiciosFinalizado;
        }

        public void muestraDatosAbogado()
        {
            Console.WriteLine($""""
            Los datos especificos del ABOGADO son:
            Nombre de juzgado: {NombreJuzgado}
            Num. de juicios en proceso: {NroJuiciosProceso}
            Num. de juicios finalizados: {NroJuiciosFinalizado}
            

            """");
        }
    }
}

