using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.CategoriaCC;
using Contratos;

namespace Back_Office.GUI.Categoria
{
    public partial class ConsultarCategoria : System.Web.UI.Page, IContratoConsultarCategoria
    {
        #region contrato

        public string categoriasCreadas
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
            set { alert.Attributes[ResourceGUICategoria.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUICategoria.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region presentador
        PresentadorConsultaCategoria _presentador;

        public ConsultarCategoria()
        {
            _presentador = new PresentadorConsultaCategoria(this);
        }
        #endregion    

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUICategoria.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.cargarConsultarCategorias();
            }

        }
    }
}