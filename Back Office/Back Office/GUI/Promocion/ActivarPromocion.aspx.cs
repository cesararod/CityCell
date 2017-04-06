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
using Contratos.Usuario;

namespace Back_Office.GUI.Promocion
{
    public partial class ActivarPromocion : System.Web.UI.Page, IContratoActivarUsuario
    {
        #region contrato
        public string UsuId
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

        public string activo
        {
            get { return this.Activo.Value; }
            set { this.Activo.Value = value; }
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

         #region constructor
        PresentadorActivar Presentador;

        public ActivarPromocion()
        {
            Presentador = new PresentadorActivar(this);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuId = Request.QueryString[ResourceGUIPromocion.idpromo];
                int status = int.Parse(Request.QueryString[ResourceGUIPromocion.estado]);
                if (status == 0)
                    activo = "1";
                if (status == 1)
                    activo = "0";
                Presentador.Modificar();
                //   Request.QueryString[ResourceGUIPromocion.prodmodelo], Request.QueryString[ResourceGUIPromocion.proddescripcion],
                //  Request.QueryString[ResourceGUIPromocion.prodprecio], Request.QueryString[ResourceGUIPromocion.cantidad]);
                Response.Redirect(ResourceGUIPromocion.volver);

            }
            catch
            {
                Response.Redirect(ResourceGUIPromocion.volver);
            }
        }
    }
}