using Dominio;
using LogicaCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows;
using Contratos.Garantia;
using Presentador.GarantiaCC;

namespace Back_Office.GUI.Garantia
{
    public partial class AgregarGarantia : System.Web.UI.Page, IContratoAgregarGarantia
    {

        #region contrato

        public DropDownList categoria
        {
            get
            {
                return Categoria;
            }
            set
            {
                Categoria = value;
            }
        }

        public DropDownList marca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
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

        #region constructor
        PresentadorAgregarGarantia Presentador;

        public AgregarGarantia()
        {
            Presentador = new PresentadorAgregarGarantia(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Presentador.CargarMarcas();
                Presentador.CargarCategorias();
            }
        }

        protected void buttonGenerar_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            Presentador.Generar();
            Response.Redirect(ResourceGUIGarantia.regresar);
        }
    }
}