using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos.Usuario;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.UsuarioCC
{
    public class PresentadorConsultaUsuario
    {
        IContratoConsultarUsuario vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaUsuario(IContratoConsultarUsuario vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// <param name="msj">Mensaje a mostrar a interfaz</param>
        /// Son respuestas positivas sobre acciones del usuario
        /// </summary>
        public void Alerta(string msj)
        {
            if (msj == RecursoPresentadorUsuario.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorUsuario.alertaModificado;
                vista.alertaRol = RecursoPresentadorUsuario.tipoAlerta;
                vista.alerta = RecursoPresentadorUsuario.alertaHtml + RecursoPresentadorUsuario.MsjModificado
                    + RecursoPresentadorUsuario.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorUsuario.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorUsuario.alertaModificado;
                vista.alertaRol = RecursoPresentadorUsuario.tipoAlerta;
                vista.alerta = RecursoPresentadorUsuario.alertaHtml + RecursoPresentadorUsuario.MsjMAnulado
                    + RecursoPresentadorUsuario.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorUsuario.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorUsuario.alertaModificado;
                vista.alertaRol = RecursoPresentadorUsuario.tipoAlerta;
                vista.alerta = RecursoPresentadorUsuario.alertaHtml + RecursoPresentadorUsuario.MsjCorreo
                    + RecursoPresentadorUsuario.alertaHtmlFinal;
            }
        }

        public void CargarConsultarPromocion()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosUsuarios();
                List<Entidad> usuario = comando.Ejecutar();

                foreach (Usuario ElUsuario in usuario)
                {

                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTr;
                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + ElUsuario.IdUser.ToString()
                        + RecursoPresentadorUsuario.CloseTd;
                    /*vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + ElUsuario.Fk_Producto
                        + RecursoPresentadorUsuario.CloseTd;
                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + ElUsuario.Fecha_Creacion
                        + RecursoPresentadorUsuario.CloseTd;
                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + ElUsuario.Fecha_Fin
                        + RecursoPresentadorUsuario.CloseTd;
                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + ElUsuario.Fecha_Creacion
                        + RecursoPresentadorUsuario.CloseTd;
                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + ElUsuario.Precio
                        + RecursoPresentadorUsuario.CloseTd;*/

                    //Equals cero para factura "Por Pagar"
                   /* if (ElUsuario.Activo.Equals(0))
                    {
                        vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + RecursoPresentadorUsuario.porActivar
                            + RecursoPresentadorUsuario.CloseTd;

                    }
                    //Equals uno para factura "Pagada"
                    else if (ElUsuario.Activo.Equals(1))
                    {
                        activada = true;
                        vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD + RecursoPresentadorUsuario.Activada
                            + RecursoPresentadorUsuario.CloseTd;
                    }*/

                    //Acciones de cada contacto
                    vista.usuariosCreados += RecursoPresentadorUsuario.OpenTD;

                    if (activada == true)
                    {
                        vista.usuariosCreados +=
                            RecursoPresentadorUsuario.BotonModif + ElUsuario.IdUser.ToString()
                            + RecursoPresentadorUsuario.CloseBotonParametro;
                    }
                    else
                    {
                        vista.usuariosCreados +=
                            RecursoPresentadorUsuario.BotonModif + ElUsuario.IdUser.ToString()
                            + RecursoPresentadorUsuario.CloseBotonParametro
                            + RecursoPresentadorUsuario.BotonAnular + ElUsuario.IdUser.ToString()
                            + RecursoPresentadorUsuario.CloseBotonParametro;
                    }
                    vista.usuariosCreados += RecursoPresentadorUsuario.CloseTd;
                    vista.usuariosCreados += RecursoPresentadorUsuario.CloseTr;
                    activada = false;

                }

            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }
    }
}
