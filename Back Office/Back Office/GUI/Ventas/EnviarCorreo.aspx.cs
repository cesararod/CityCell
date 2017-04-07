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
    public partial class EnviarCorreo : System.Web.UI.Page, IContratoCorreo
    {
        #region contrato
        public string VenId
        {
            get
            {
                return this.IdUsuario.Value;
            }
            set
            {
                this.IdUsuario.Value = value;
            }
        }

        public string Status
        {
            get { return this.Activo.Value; }
            set { this.Activo.Value = value; }
        }

        public string Mail
        {
            get { return this.mail.Value; }
            set { this.mail.Value = value; }
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
        PresentadorCorreo _presentador;

        public EnviarCorreo()
        {
            _presentador = new PresentadorCorreo(this);
        }
        #endregion  

        protected void Page_Load(object sender, EventArgs e)
        {
            VenId = Request.QueryString[ResourceGUIVenta.idven];
            Status = Request.QueryString[ResourceGUIVenta.status];
            Mail = Request.QueryString[ResourceGUIVenta.correo];
            _presentador.enviarCorreo();
            Response.Redirect(ResourceGUIVenta.volver);
        }
    }
}