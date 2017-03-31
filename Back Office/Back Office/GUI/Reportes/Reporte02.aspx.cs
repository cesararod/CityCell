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
    public partial class Reporte02 : System.Web.UI.Page, IContratoReporte2
    {
        #region contrato
        
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
        PresentadorReporte2 _presentador;

        public Reporte02()
        {
            _presentador = new PresentadorReporte2(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[Recurso.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.CargarReporte();
            }
        }
    }
}