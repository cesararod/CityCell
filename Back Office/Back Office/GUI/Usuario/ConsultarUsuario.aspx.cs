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
    public partial class ConsultarUsuario : System.Web.UI.Page, IContratoConsultarUsuario
    {
        #region contrato

        public string usuariosCreados
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

        #region presentador
        PresentadorConsultaUsuario _presentador;

        public ConsultarUsuario()
        {
            _presentador = new PresentadorConsultaUsuario(this);
        }
        #endregion  

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUIUsuario.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.CargarConsultarUsuario();
            }

        }
    }
}