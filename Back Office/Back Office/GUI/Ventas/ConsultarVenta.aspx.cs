using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.VentaCC;
using Contratos.Venta;


namespace Back_Office.GUI.Ventas
{
    public partial class ConsultarVenta : System.Web.UI.Page, IContratoConsultarVenta
    {
        #region contrato

        public string ventasCreados
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

        #region presentador
        PresentadorConsultaVenta _presentador;

        public ConsultarVenta()
        {
            _presentador = new PresentadorConsultaVenta(this);
        }
        #endregion  

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUIVenta.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.CargarConsultar();
                //_presentador.enviarCorreo();
            }
        }
    }
}