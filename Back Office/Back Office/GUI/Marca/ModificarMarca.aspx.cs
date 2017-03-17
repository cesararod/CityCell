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
    public partial class ModificarMarca : System.Web.UI.Page, IContratoModificarMarca
    {
        #region Implementacion de Contrato

        public string id_Marca
        {
            get { return this.IdMarca.Value; }
            set { this.IdMarca.Value = value; }
        }

        public DropDownList activo
        {
            get { return activoMarca; }
            set { activoMarca = value; }
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

        #region Constructor
        PresentadorModificarMarca _presentador;

        public ModificarMarca()
        {
            _presentador = new PresentadorModificarMarca(this);
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                id_Marca = Request.QueryString[ResourceGUIMarca.idMarca]; 

            }
            catch
            {
                Response.Redirect(ResourceGUIMarca.volver);
            }

        }

        protected void buttonModificarMarca_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            _presentador.Modificar();
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}