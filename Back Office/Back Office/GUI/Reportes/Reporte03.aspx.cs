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
    public partial class Reporte03 : System.Web.UI.Page, IContratoReporte3
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

        public DropDownList categoria
        {
            get
            {
                return this.Categoria;
            }
            set
            {
                this.Categoria = value;
            }
        }

        public string TablaReporte
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
        PresentadorReporte3 _presentador;

        public Reporte03()
        {
            _presentador = new PresentadorReporte3(this);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                _presentador.CargarCategorias();
            }
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