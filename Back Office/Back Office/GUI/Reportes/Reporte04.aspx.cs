using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.ReporteCC;
using Contratos.Reportes;

namespace Back_Office.GUI.Reportes
{
    public partial class Reporte04 : System.Web.UI.Page, IContratoReporte2
    {
        #region contrato

        public DropDownList Estado
        {
            get
            {
                return this.Activo;
            }
            set
            {
                this.Activo = value;
            }
        }

        public string TablaReporte2
        {
            get
            {
                return this.tabla.Text;
            }

            set
            {
                this.tabla.Text = value;
            }
        }

        public string alertaClase
        {
            set { alert.Attributes[Recurso.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[Recurso.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region presentador
        PresentadorReporte4 _presentador;

        public Reporte04()
        {
            _presentador = new PresentadorReporte4(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonBuscar(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            _presentador.CargarReporte();
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}