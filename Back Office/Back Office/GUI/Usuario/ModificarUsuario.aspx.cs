using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ExceptionCity;
using LogicaCC;
using Presentador.UsuarioCC;
using Contratos.Usuario;
namespace Back_Office.GUI.Usuario
{
    public partial class ModificarUsuario : System.Web.UI.Page, IContratoModificarUsuario
    {
        
        #region contrato
        public string UsuId
        {
            get
            {
                return this.IdUsuario.Value; ;
            }
            set
            {
                this.IdUsuario.Value = value;
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

         #region constructor
        PresentadorModificarUsuario Presentador;

        public ModificarUsuario()
        {
            Presentador = new PresentadorModificarUsuario(this);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuId = Request.QueryString[ResourceGUIUsuario.idUsu];
                Nombre = Request.QueryString[ResourceGUIUsuario.nombreUsu];
                Apellido = Request.QueryString[ResourceGUIUsuario.apellidoUsu];
                Cedula = Request.QueryString[ResourceGUIUsuario.cedulaUsu];
                //_presentador.LLenarModificar(Request.QueryString[ResourceGUIProducto.prodnombre],
                 //   Request.QueryString[ResourceGUIUsuario.prodmodelo], Request.QueryString[ResourceGUIUsuario.proddescripcion],
                  //  Request.QueryString[ResourceGUIUsuario.prodprecio], Request.QueryString[ResourceGUIUsuario.cantidad]);


            }
            catch
            {
                Response.Redirect(ResourceGUIUsuario.volver);
            }
        }

        protected void buttonUsuario_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            Presentador.Modificar();
            //Response.Redirect(ResourceGUIUsuario.Factura + _presentador.ResourceGUIUsuario().ToString());
        }
    }
}