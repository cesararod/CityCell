using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Reporte : Entidad
    {
        #region Atributos
        private string apellido;
        private string nombre;
        private string ciudad;
        private float subtotal;
        private DateTime fecha;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int estado_id;

        #endregion

        #region Get's Set's

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }

        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }

        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }

        }

        public DateTime Fecha_Inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }

        }

        public DateTime Fecha_Fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }

        }

        public int Estado_Id
        {
            get { return estado_id; }
            set { estado_id = value; }

        }
        #endregion


        #region Constructores

        public Reporte()
        {
            this.nombre = String.Empty;
            this.apellido = String.Empty;
            this.ciudad = String.Empty;
            this.fecha = DateTime.Now;
            this.subtotal = 0;
        }


        public Reporte(string inputNombre, string inputApellido, string inputCiudad, DateTime inputFecha, float inputSubtotal)
        {

            this.nombre = inputNombre;
            this.apellido = inputApellido;
            this.ciudad = inputCiudad;
            this.fecha = inputFecha;
            this.subtotal = inputSubtotal;
        }
        #endregion
    }
}
