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
using Contratos.Producto;

namespace Back_Office.GUI.Producto
{
    public partial class ConsultarProducto : System.Web.UI.Page, IContratoConsultarProducto
    {
        #region contrato

        public string productosCreados
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

        #region presentador
        PresentadorConsultaProductos _presentador;

        public ConsultarProducto()
        {
            _presentador = new PresentadorConsultaProductos(this);
        }
        #endregion  

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUIProducto.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.CargarConsultarProductos();
            }

        }
    }
}