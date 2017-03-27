using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Venta : Entidad
    {
        #region Atributos
        private int id_venta;
        private string nombre;
        private string apellido;
        private string tracking;
        private DateTime fecha_creacion;
        private string subtotal;
        private string pedido;
        private string iva;
        private string precioEnvio;
        private string estatus;
        private string dirFact;
        private string dirEnv;
        private string numPago;
        private string operador;
        private string producto;
        private string modelo;
        private string marca;
        private string mail;

        #endregion

        #region Get's Set's

        public int Id_Venta
        {
            get { return id_venta; }
            set { id_venta = value; }

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public string Tracking
        {
            get { return tracking; }
            set { tracking = value; }

        }

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }

        }

        public string Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }

        }

        public string Pedido
        {
            get { return pedido; }
            set { pedido = value; }

        }

        public string Iva
        {
            get { return iva; }
            set { iva = value; }

        }

        public string PrecioEnvio
        {
            get { return precioEnvio; }
            set { precioEnvio = value; }

        }

        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }

        }

        public string DirFact
        {
            get { return dirFact; }
            set { dirFact = value; }

        }

        public string DirEnv
        {
            get { return dirEnv; }
            set { dirEnv = value; }

        }

        public string NumPago
        {
            get { return numPago; }
            set { numPago = value; }

        }

        public string Operador
        {
            get { return operador; }
            set { operador = value; }

        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }

        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }

        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }

        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }

        }

        #endregion\

        #region Constructores
       
                    
        public Venta(int inputId, string input_Nombre, string input_Apellido, string input_tracking, string input_subtotal, string input_pedido,
             DateTime input_fechaCreacion, string input_iva, string input_precioEnvio, string input_estatus, string input_dirFact, string input_dirEnv,
             string input_numPago, string input_operador, string input_producto, string input_modelo, string input_marca, string input_mail)
        {
            id_venta = inputId;
            nombre = input_Nombre;
            apellido = input_Apellido;
            tracking = input_tracking;
            subtotal = input_subtotal;
            pedido = input_pedido;
            fecha_creacion = input_fechaCreacion;
            iva = input_iva;
            precioEnvio = input_precioEnvio;
            estatus = input_estatus;
            dirFact = input_dirFact;
            dirEnv = input_dirEnv;
            numPago = input_numPago;
            operador = input_operador;
            producto = input_producto;
            modelo = input_modelo;
            marca = input_marca;
            mail = input_mail;
        }

        public Venta()
        {
            id_venta = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            tracking = string.Empty;
            subtotal = string.Empty;
            pedido = string.Empty;
            fecha_creacion = DateTime.Now;
            iva = string.Empty;
            precioEnvio = string.Empty;
            estatus = string.Empty;
            dirFact = string.Empty;
            dirEnv = string.Empty;
            numPago = string.Empty;
            operador = string.Empty;
            producto = string.Empty;
            modelo = string.Empty;
            marca = string.Empty;
            mail = string.Empty;
        }
      
        #endregion
    }
}
