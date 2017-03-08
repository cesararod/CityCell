using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.MarcaCC;
using Contratos.Marca;

namespace Back_Office.GUI.Marca
{
    public partial class ConsultarMarca : System.Web.UI.Page, IContratoConsultarMarca
    {
        #region contrato

        public string marcasCreadas
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
            set { alert.Attributes[ResourceGUIMarca.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIMarca.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region presentador
        PresentadorConsultaMarca _presentador;

        public ConsultarMarca()
        {
            _presentador = new PresentadorConsultaMarca(this);
        }
        #endregion    

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto ocurre cuando se modifica una factura, se muestra mensaje a usuario
                string _estado = Request.QueryString[ResourceGUIMarca.estado];
                if (_estado != null)
                    _presentador.Alerta(_estado);
            }
            catch
            {
                //No hago nada, no es obligatorio el parametro
            }
            if (!IsPostBack)
            {
                _presentador.cargarConsultarMarcas();
            }
        }
    }
}