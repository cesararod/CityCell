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
    public partial class ModificarGarantia : System.Web.UI.Page, IContratoModificarGarantia
    {
        #region Implementacion de Contrato

        public string idGar
        {
            get { return this.IdGar.Value; }
            set { this.IdGar.Value = value; }
        }

        public string descripcion
        {
            get { return this.InputDescripcion.Value; }
            set { this.InputDescripcion.Value = value; }
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

        #region Constructor
        PresentadorModificarGarantia _presentador;

        public ModificarGarantia()
        {
            _presentador = new PresentadorModificarGarantia(this);
        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                idGar = Request.QueryString[ResourceGUIGarantia.idGar]; ;

            }
            catch
            {
                Response.Redirect(ResourceGUIGarantia.volver);
            }
        }

        protected void buttonGenerar_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            _presentador.Modificar();
            Response.Redirect(ResourceGUIGarantia.regresar);
        }
    }
}