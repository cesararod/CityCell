﻿using Dominio;
using LogicaCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows;
using Contratos.Promocion;
using Presentador.PromocionCC;

namespace Back_Office.GUI.Promocion
{
    public partial class AgregaPromocion : System.Web.UI.Page, IContratoAgregarPromocion
    {
        private string[] Substrings;
        private string fecha;

        #region Contratos
        public DropDownList producto
        {
            get
            {
                return this.Producto;
            }
            set
            {
                this.Producto = value;
            }
        }

        public DropDownList activo
        {
            get
            {
                return this.activoInput;
            }
            set
            {
                this.activoInput = value;
            }
        }

        public string precio
        {
            get { return this.InputPrecio.Value; }
            set { this.InputPrecio.Value = value; }
        }

        public string Fecha_Inicio
        {
            get
            {
                Substrings = this.fecha_inicio.Value.ToString().Split('-');
                fecha = Substrings[1] + '/' + Substrings[2] + '/' + Substrings[0];
                return fecha;
            }
            set { this.fecha_inicio.Value = value; }
        }

        public string Fecha_Fin
        {
            get
            {
                Substrings = this.fecha_fin.Value.ToString().Split('-');
                fecha = Substrings[1] + '/' + Substrings[2] + '/' + Substrings[0];
                return fecha;
            }
            set { this.fecha_fin.Value = value; }
        }

        public string alertaClase
        {
            set { alert.Attributes[ResourceGUIPromocion.alertClase] = value; }
        }

        public string alertaRol
        {
            set { alert.Attributes[ResourceGUIPromocion.alertRole] = value; }
        }

        public string alerta
        {
            set { alert.InnerHtml = value; }
        }
        #endregion

        #region constructor
        PresentadorAgregarPromocion Presentador;

        public AgregaPromocion()
        {
            Presentador = new PresentadorAgregarPromocion(this);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Presentador.CargarProductos();
            }

        }

        protected void buttonGenerarPromo_Click(object sender, EventArgs e)
        {
            //this.nombre = Request.QueryString[ResourceGUICategoria.idC];
            //this.activo = Request.QueryString[ResourceGUICategoria.idP];
            //this.destacado = Request.QueryString[ResourceGUICategoria.amount];
            Presentador.GenerarPromocion();
            Response.Redirect(ResourceGUIPromocion.volver);
            //Response.Redirect(ResourceGUICategoria.Factura + _presentador.ResourceGUICategoria().ToString());
        }
    }
}