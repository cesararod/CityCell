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
using Contratos.Categoria;

namespace Back_Office.GUI.Categoria
{
    public partial class ModificarCategoria : System.Web.UI.Page, IContratoModificarCategoria
    {
        #region Implementacion de Contrato

        public string id_Categoria
        {
            get { return this.IdCat.Value; }
            set { this.IdCat.Value = value; }
        }

        public DropDownList activo
        {
            get { return activoCat; }
            set { activoCat = value; }
        }

        public DropDownList destacado
        {
            get { return destacadoCat; }
            set { destacadoCat = value; }
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

        DateTime _fechaEmision = DateTime.Now;
        DateTime _fechaUltimoPago = DateTime.Now;
        static int _montoTotal = 0;
        int _montoRestante = 0;
        string _tipoMoneda = String.Empty;
        string _Descripcion = String.Empty;
        int _estatus = 0;
        static int _proyectoId = 0;
        static int _companiaId = 0;
        #endregion

        #region Constructor
        PresentadorModificarCategoria _presentador;

        public ModificarCategoria()
        {
            _presentador = new PresentadorModificarCategoria(this);
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                id_Categoria = Request.QueryString[ResourceGUICategoria.idCat]; ;
                
            }
            catch
            {
                Response.Redirect(ResourceGUICategoria.volver);
            }

        }

        protected void buttonModificarCategoria_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            _presentador.ModificarCategoria();
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}