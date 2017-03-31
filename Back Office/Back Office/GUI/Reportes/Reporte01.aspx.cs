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
    public partial class Reporte01 : System.Web.UI.Page, IContratoReporte1
    {

        private string[] Substrings;
        private string fecha;
        private string fecha2;
        #region contrato
        public string Fecha_Inicio
        {
            get
            {
                Substrings = fecha_inicio.Value.ToString().Split('-');
                fecha2 = Substrings[1] + '/' + Substrings[2] + '/' + Substrings[0];
                return fecha2;
            }
            set { this.fecha_inicio.Value = value; }
        }

        public string Fecha_Fin
        {
            get
            {
                Substrings = fecha_fin.Value.ToString().Split('-');
                fecha = Substrings[1] + '/' + Substrings[2] + '/' + Substrings[0];
                return fecha;
            }
            set { this.fecha_fin.Value = value; }
        }

        public DropDownList Estado
        {
            get
            {
                return this.inputEstado;
            }
            set
            {
                this.inputEstado = value;
            }
        }

        public string TablaReporte1
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
        PresentadorReporte1 _presentador;

        public Reporte01()
        {
            _presentador = new PresentadorReporte1(this);
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
            _presentador.CargarReporte1();
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}