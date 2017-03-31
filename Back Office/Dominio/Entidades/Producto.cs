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
        private int id_Prod;
        private string nombre;
        private string marcaNombre;
        private string categoriaNombre;
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

        public int IdProducto
        {
            get { return id_Prod; }
            set { id_Prod = value; }
        } 

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
           
        }

        public string MarcaNombre
        {
            get { return marcaNombre; }
            set { marcaNombre = value; }

        }

        public string CategoriaNombre
        {
            get { return categoriaNombre; }
            set { categoriaNombre = value; }

        }
        public int Activo
        {
            get { return activo; }
            set { activo = value; }
            
        } 

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
            
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }

        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }

        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }

        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }

        }

        public float Alto
        {
            get { return alto; }
            set { alto = value; }

        }

        public float Ancho
        {
            get { return ancho; }
            set { ancho = value; }

        }

        public float Largo
        {
            get { return largo; }
            set { largo = value; }

        }

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }

        }

        public DateTime Fecha_Modificacion
        {
            get { return fecha_modificacion; }
            set { fecha_modificacion = value; }

        }

        public int Fk_Marca
        {
            get { return fk_marca; }
            set { fk_marca = value; }

        }

        public int Fk_Categoria
        {
            get { return fk_categoria; }
            set { fk_categoria = value; }

        }
        #endregion

        #region Constructores

        public Producto()
        {
            id_Prod = 0;
            nombre = String.Empty;
            marcaNombre = String.Empty;
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
            , int inputMarca, int inputCategoria, string inputMarcaNombre, string inputCategoriaNombre)    
        {
            id_Prod = inputId;
            nombre = inputNombre;
            marcaNombre = inputMarcaNombre;
            categoriaNombre = inputCategoriaNombre;
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

        public Producto(int inputId, string inputNombre, int inputActivo, string inputModelo, string inputDescripcion, float inputPrecio,
           int inputCantidad, float inputPeso, float inputAlto, float inputAncho, float inputLargo, DateTime inputFechaCrea, DateTime inputFechaMod
           , int inputMarca, int inputCategoria)
        {
            id_Prod = inputId;
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
