using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2D
{
    // clase PADRE
    public class Profesional
    {
        private DateTime fechaEgreso;
        private long nroTituloAcademico;
        private string? cedulaIdentidad;
        private string? nombres;
        private string? primerApellido;
        private string? segundoApellido;
        private string? direccion;
        private int antiguedad;


        public DateTime FechaEgreso { get => fechaEgreso; set => fechaEgreso = value; }
        public long NroTituloAcademico { get => nroTituloAcademico; set => nroTituloAcademico = value; }
        public string CedulaIdentidad { get => cedulaIdentidad; set => cedulaIdentidad = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }

        public Profesional(DateTime fechaEgreso,long nroTituloAcademico,string cedulaIdentidad,string nombres,string primerApellido,string segundoApellido,string direccion)
        {
            this.FechaEgreso = fechaEgreso;
            this.NroTituloAcademico = nroTituloAcademico;
            this.CedulaIdentidad = cedulaIdentidad;
            this.Nombres = nombres;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Direccion = direccion;

        }
        public void muestraDatosProfesional(Profesional profesional)
        {
            Console.WriteLine($""""

            Los datos del PROFESIONAL son:
            Fecha de Egreso: {profesional.fechaEgreso}
            Num. Tit. Academico: {profesional.nroTituloAcademico}
            Num. Cedula: {profesional.cedulaIdentidad}
            Nombre completo: {profesional.nombres} {profesional.primerApellido} {profesional.segundoApellido}
            Direccion: {profesional.direccion}
            
            """");
        }

        public virtual void aniversario()
        {
            antiguedad = DateTime.Today.Year - FechaEgreso.Year;
        }
    }
}
