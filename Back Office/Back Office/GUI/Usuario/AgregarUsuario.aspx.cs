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
using Contratos.Usuario;
using Presentador.UsuarioCC;

namespace Back_Office.GUI.Usuario
{
    public partial class AgregarUsuario : System.Web.UI.Page, IContratoAgregarUsuario
    {
        private PresentadorAgregarUsuario presentador;      
        private string[] Substrings;
        private string fecha;

        #region contrato
        public DropDownList Rol
        {
            get
            {
                return rol;
            }
            set
            {
                rol = value;
            }
        }

        public DropDownList TipoDoc
        {
            get
            {
                return tipodoc;
            }
            set
            {
                tipodoc = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre.Value; }
            set { this.nombre.Value = value; }
        }

        public string Apellido
        {
            get { return this.apellido.Value; }
            set { this.apellido.Value = value; }
        }

        public string Cedula
        {
            get { return this.cedula.Value; }
            set { this.cedula.Value = value; }
        }

        public DropDownList Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }

        public string Telefono
        {
            get { return this.InputTelefono.Value; }
            set { this.InputTelefono.Value = value; }
        }

        public string Celular
        {
            get { return this.celular.Value; }
            set { this.celular.Value = value; }
        }

        public string Password
        {
            get { return this.password.Value; }
            set { this.password.Value = value; }
        }

        public string Fecha_Nnacimiento
        {
            get
            {
                Substrings = fecha_nacimineto.Value.ToString().Split('-');
                fecha = Substrings[1] + '/' + Substrings[2] + '/' + Substrings[0];
                return fecha;
            }
            set { this.fecha_nacimineto.Value = value; }
        }

        public string Correo
        {
            get { return this.EmailPerson.Value; }
            set { this.EmailPerson.Value = value; }
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonGenerarUsuario_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            //Presentador.GenerarUsuario();
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}