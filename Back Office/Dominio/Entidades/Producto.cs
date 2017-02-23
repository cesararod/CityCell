using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Producto : Entidad
    {
        #region Atributos
        private int id;
        private string nombre;
        private int activo;
        private string modelo;
        private string descripcion;
        private float precio;
        private int cantidad;
        private float peso;
        private float alto;
        private float ancho;
        private float largo;
        private int fk_marca;
        private int fk_categoria;
        private DateTime fecha_creacion;
        private DateTime fecha_modificacion;
        #endregion

        #region Get's Set's

        public int ID
        {
            get { return id; }
        } 

        public string Nombre
        {
            get { return nombre; }
           
        }
        
        public int Activo
        {
            get { return activo; }
            
        } 

        public string Modelo
        {
            get { return modelo; }
            
        }

        public string Descripcion
        {
            get { return descripcion; }

        }

        public float Precio
        {
            get { return precio; }

        }

        public int Cantidad
        {
            get { return cantidad; }

        }

        public float Peso
        {
            get { return peso; }

        }

        public float Alto
        {
            get { return alto; }

        }

        public float Ancho
        {
            get { return ancho; }

        }

        public float Largo
        {
            get { return largo; }

        }

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }

        }

        public DateTime Fecha_Modificacion
        {
            get { return fecha_modificacion; }

        }

        public int Fk_Marca
        {
            get { return fk_marca; }

        }

        public int Fk_Categoria
        {
            get { return fk_categoria; }

        }
        #endregion

        #region Constructores

        public Producto()
        {
            Id = 0;
            nombre = String.Empty;
            activo = 0;
            modelo = String.Empty;
            descripcion = String.Empty;
            precio = 0;
            cantidad = 0;
            peso = 0;
            alto = 0;
            ancho = 0;
            largo = 0;
            fk_marca = 0;
            fk_categoria = 0;
            fecha_creacion = DateTime.Now;
            fecha_modificacion = DateTime.Now;
        }

        public Producto(int inputId, string inputNombre, int inputActivo, string inputModelo, string inputDescripcion, float inputPrecio,
            int inputCantidad, float inputPeso, float inputAlto, float inputAncho, float inputLargo, DateTime inputFechaCrea, DateTime inputFechaMod
            , int inputMarca, int inputCategoria)    
        {
            Id = inputId;
            nombre = inputNombre;
            activo = inputActivo;
            modelo = inputModelo;
            descripcion = inputDescripcion;
            precio = inputPrecio;
            cantidad = inputCantidad;
            peso = inputPeso;
            alto = inputAlto;
            ancho = inputAncho;
            largo = inputLargo;
            fecha_creacion = inputFechaCrea;
            fecha_modificacion = inputFechaMod;
            fk_marca = inputMarca;
            fk_categoria = inputCategoria;
        }
      
        #endregion
    }
}
