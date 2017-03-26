using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.GarantiaCC;
using Contratos.Garantia;

namespace Back_Office.GUI.Garantia
{
    public partial class ConsultarGarantia : System.Web.UI.Page, IContratoConsultarGarantia
    {
        #region contrato

        public string garantiasCreadas
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
            set { alert.Attributes[ResourceGUIGarantia.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIGarantia.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region presentador
        PresentadorConsultaGarantia _presentador;

        public ConsultarGarantia()
        {
            _presentador = new PresentadorConsultaGarantia(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUIGarantia.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.cargarConsultar();
            }
        }
    }
}