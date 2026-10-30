using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2D
{
    public class Medico: Profesional
    {
        private string unidadTrabajo;
        private long nroConsultasMedicas;
        private long nroConsultasDomicilio;
        private long nroCirugias;
        

        public string UnidadTrabajo { get => unidadTrabajo; set => unidadTrabajo = value; }
        public long NroConsultasMedicas { get => nroConsultasMedicas; set => nroConsultasMedicas = value; }
        public long NroConsultasDomicilio { get => nroConsultasDomicilio; set => nroConsultasDomicilio = value; }
        public long NroCirugias { get => nroCirugias; set => nroCirugias = value; }
        

        public Medico(DateTime fechaEgreso,long nroTituloAcademico,string cedulaIdentidad,string nombres, string primerApellido,string segundoApellido,string direccion,string unidadTrabajo,long nroConsultasMedicas,long nroConsultasDomicilio,long nroCirugias) : base(fechaEgreso,nroTituloAcademico,cedulaIdentidad,nombres,primerApellido,segundoApellido,direccion)
        {
            this.UnidadTrabajo = unidadTrabajo;
            this.NroConsultasMedicas = nroConsultasMedicas;
            this.NroConsultasDomicilio = nroConsultasDomicilio;
            this.NroCirugias = nroCirugias;
        }

        public void muestraDatosMedico()
        {
            Console.WriteLine($""""
            Los datos del espedificos del MEDICO son:
            Unidad de trabajo: {UnidadTrabajo}
            Num. de consultas medicas: {NroConsultasMedicas}
            Num. de consultas a domicilio: {NroConsultasDomicilio}
            Num. de cirugias: {NroCirugias}
            

            """");
        }

        
    }
}
