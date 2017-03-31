using Dominio;
using LogicaCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows;
using Contratos.Producto;
using Presentador.ProductoCC;

namespace Back_Office.GUI.Producto
{
    public partial class AgregaProducto : System.Web.UI.Page, IContratoAgregarProducto
    {
        #region contrato
        public DropDownList categoria
        {
            get
            {
                return Categoria;
            }
            set
            {
                Categoria = value;
            }
        }

        public DropDownList marca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }

        public DropDownList activo
        {
            get
            {
                return Activo;
            }
            set
            {
                Activo = value;
            }
        }

        public string nombre
        {
            get { return this.InputNombre.Value; }
            set { this.InputNombre.Value = value; }
        }

        public string modelo
        {
            get { return this.InputModelo.Value; }
            set { this.InputModelo.Value = value; }
        }

        public string descripcion
        {
            get { return this.InputDescripcion.Value; }
            set { this.InputDescripcion.Value = value; }
        }

        public string precio
        {
            get { return this.InputPrecio.Value; }
            set { this.InputPrecio.Value = value; }
        }

        public string cantidad
        {
            get { return this.Cantidad.Value; }
            set { this.Cantidad.Value = value; }
        }

        public string peso
        {
            get { return this.Peso.Value; }
            set { this.Peso.Value = value; }
        }

        public string alto
        {
            get { return this.Alto.Value; }
            set { this.Alto.Value = value; }
        }

        public string ancho
        {
            get { return this.Ancho.Value; }
            set { this.Ancho.Value = value; }
        }

        public string largo
        {
            get { return this.Largo.Value; }
            set { this.Largo.Value = value; }
        }

        public string alertaClase
        {
            set { alert.Attributes[ResourceGUIProducto.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIProducto.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region constructor
        PresentadorAgregarProducto Presentador;

        public AgregaProducto()
        {
            Presentador = new PresentadorAgregarProducto(this);
        }
        #endregion
        
                
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Presentador.CargarMarcas();
                Presentador.CargarCategorias();
            }
        }

        protected void buttonGenerarProducto_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            Presentador.GenerarProducto();
            Response.Redirect(ResourceGUIProducto.Retornar);
        }
    }
}