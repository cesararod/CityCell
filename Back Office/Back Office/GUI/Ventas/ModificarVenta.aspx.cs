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
using Contratos.Venta;
using Presentador.VentaCC;
using ExceptionCity;

namespace Back_Office.GUI.Ventas
{
    public partial class ModificarVenta : System.Web.UI.Page, IContratoModificarVenta
    {

        #region contrato
        public string VentaId
        {
            get
            {
                return this.orden.Value; ;
            }
            set
            {
                this.orden.Value = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre.Value; }
            set { this.nombre.Value = value; }
        }

        public string Producto
        {
            get { return this.producto.Value; }
            set { this.producto.Value = value; }
        }

        public DropDownList Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

        public string alertaClase
        {
            set { alert.Attributes[ResourceGUIVenta.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIVenta.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

         #region constructor
        PresentadorModificarVenta Presentador;

        public ModificarVenta()
        {
            Presentador = new PresentadorModificarVenta(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                VentaId = Request.QueryString[ResourceGUIVenta.idVenta];

                Nombre = Request.QueryString[ResourceGUIVenta.nombreUsu];

                Producto = Request.QueryString[ResourceGUIVenta.ventaProd];              


            }
            catch
            {
                Response.Redirect(ResourceGUIVenta.volver);
            }
        }

        protected void buttonGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
                //this.activo = Request.QueryString[ResourceGUICategoria.idP];
                //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
                Presentador.Modificar();
                //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}