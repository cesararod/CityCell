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
        private string estatus;
        private string categoria;
        private string marca;
        private string ciudad;
        private string pedido;
        private string producto;
        private float subtotal;
        private float total;
        private DateTime fecha;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int estado_id;
        private int activo;

        #endregion

        #region Get's Set's

        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }

        }

        public string Pedido
        {
            get { return pedido; }
            set { pedido = value; }

        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }

        }

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

        public string Marca
        {
            get { return marca; }
            set { marca = value; }

        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }

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

        public float Total
        {
            get { return total; }
            set { total = value; }

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

        public int Activo
        {
            get { return activo; }
            set { activo = value; }

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

        public Reporte(string inputNombre, string inputEstatus, string inputPedido, DateTime inputFecha, float inputTotal, string inputCategoria, string inputProducto)
        {

            this.nombre = inputNombre;
            this.estatus = inputEstatus;
            this.pedido = inputPedido;
            this.fecha = inputFecha;
            this.total = inputTotal;
            this.categoria = inputCategoria;
            this.producto = inputProducto;
        }
        #endregion
    }
}
