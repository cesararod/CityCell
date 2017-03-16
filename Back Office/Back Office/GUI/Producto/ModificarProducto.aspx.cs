using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.ProductoCC;
using Contratos.Producto;

namespace Back_Office.GUI.Producto
{
    public partial class ModificarProducto : System.Web.UI.Page, IContratoModificarProducto
    {

        #region contrato

        public string id_Producto
        {
            get { return this.IdProducto.Value; }
            set { this.IdProducto.Value = value; }
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

        #region Constructor
        PresentadorModificarProducto _presentador;

        public ModificarProducto()
        {
            _presentador = new PresentadorModificarProducto(this);
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                id_Producto = Request.QueryString[ResourceGUIProducto.idProd]; ;

            }
            catch
            {
                Response.Redirect(ResourceGUIProducto.volver);
            }
        }

        protected void buttonModificar_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            _presentador.Modificar();
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}