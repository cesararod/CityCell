using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.PromocionCC;
using Contratos.Promocion;

namespace Back_Office.GUI.Promocion
{
    public partial class ConsultarPromocion : System.Web.UI.Page, IContratoConsultarPromocion
    {
        #region contrato

        public string promocionesCreadas
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
            set { alert.Attributes[ResourceGUIPromocion.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIPromocion.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region presentador
        PresentadorConsultaPromocion _presentador;

        public ConsultarPromocion()
        {
            _presentador = new PresentadorConsultaPromocion(this);
        }
        #endregion  

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUIPromocion.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.CargarConsultarPromocion();
            }

        }
    }
}