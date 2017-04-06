﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;
using LogicaCC;
using Contratos.Usuario;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;


namespace Presentador.ProductoCC
{
    public class PresentadorActivar
    {
        IContratoActivarUsuario vista;

        public PresentadorActivar(IContratoActivarUsuario vista)
        {
            this.vista = vista;
        }


         /// <summary>
         /// Método para modificar los producrtos
         /// </summary>
         public void Modificar()
         {
             try
             {
                 Usuario elUsuario = (Usuario)FabricaEntidades.UsuarioVacio();
                 elUsuario.IdUser = int.Parse(vista.UsuId.ToString());
                 elUsuario.Activo = int.Parse(vista.activo.ToString());
                 Comando<bool> comando = FabricaComandos.CrearActivarproducto(elUsuario);
                 comando.Ejecutar();
             }
             catch (ExceptionCity.ExceptionCcConBD ex)
             {
                 vista.alertaClase = RecursoPresentadorProducto.alertaError;
                 vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
                 vista.alerta = RecursoPresentadorProducto.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                     + RecursoPresentadorProducto.alertaHtmlFinal;
             }
         }
    }
}
