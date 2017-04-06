using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.UsuarioCC;
using Contratos.Usuario;

namespace Back_Office.GUI.Usuario
{
    public partial class ActivarUsuario : System.Web.UI.Page, IContratoActivarUsuario
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
            set { alert.Attributes[ResourceGUIUsuario.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIUsuario.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

         #region constructor
        PresentadorActivarUsuario Presentador;

        public ActivarUsuario()
        {
            Presentador = new PresentadorActivarUsuario(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuId = Request.QueryString[ResourceGUIUsuario.idUsu];
                int status = int.Parse(Request.QueryString[ResourceGUIUsuario.nombreUsu]);
                if (status == 0)
                    activo = "1";
                if (status == 1)
                    activo = "0";
                Presentador.Modificar();
                //   Request.QueryString[ResourceGUIUsuario.prodmodelo], Request.QueryString[ResourceGUIUsuario.proddescripcion],
                //  Request.QueryString[ResourceGUIUsuario.prodprecio], Request.QueryString[ResourceGUIUsuario.cantidad]);
                Response.Redirect(ResourceGUIUsuario.volver);

            }
            catch
            {
                Response.Redirect(ResourceGUIUsuario.volver);
            }
        }
    }
}