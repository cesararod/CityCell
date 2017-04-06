using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.ProductoCC;
using Contratos.Usuario;

namespace Back_Office.GUI.Producto
{
    public partial class ActivarProducto : System.Web.UI.Page, IContratoActivarUsuario
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
            set { alert.Attributes[ResourceGUIProducto.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIProducto.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

         #region constructor
        PresentadorActivar Presentador;

        public ActivarProducto()
        {
            Presentador = new PresentadorActivar(this);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuId = Request.QueryString[ResourceGUIProducto.idProd];
                int status = int.Parse(Request.QueryString[ResourceGUIProducto.prodnombre]);
                if (status == 0)
                    activo = "1";
                if (status == 1)
                    activo = "0";
                Presentador.Modificar();
                //   Request.QueryString[ResourceGUIProducto.prodmodelo], Request.QueryString[ResourceGUIProducto.proddescripcion],
                //  Request.QueryString[ResourceGUIProducto.prodprecio], Request.QueryString[ResourceGUIProducto.cantidad]);
                Response.Redirect(ResourceGUIProducto.volver);

            }
            catch
            {
                Response.Redirect(ResourceGUIProducto.volver);
            }
        }
    }
}