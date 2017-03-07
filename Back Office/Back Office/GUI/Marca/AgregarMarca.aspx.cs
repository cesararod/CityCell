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
    public partial class AgregarMarca : System.Web.UI.Page, IContratoAgregarMarca
    {
        #region Implementacion de Contrato
        public string nombre
        {
            get { return this.nombreMarca.Value; }
            set { this.nombreMarca.Value = value; }
        }

        public DropDownList activo
        {
            get { return activoMarca; }
            set { activoMarca = value; }
        }

        public string ruta_logo
        {
            get { return this.rutaMarca.FileName.ToString(); }
            
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

        DateTime _fechaCreacion = DateTime.Now;
        string _ruta = String.Empty;
        string _nombre = String.Empty;
        int _activo = 0;
        #endregion

        #region Constructor
        PresentadorAgregarMarca _presentador;

        public AgregarMarca()
        {
            _presentador = new PresentadorAgregarMarca(this);
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonGenerarMarca_Click(object sender, EventArgs e)
        {
            _presentador.GenerarMarca();
            rutaMarca.SaveAs(Server.MapPath(ResourceGUIMarca.ruta + rutaMarca.FileName + ResourceGUIMarca.Extencion));
        }
    }
}