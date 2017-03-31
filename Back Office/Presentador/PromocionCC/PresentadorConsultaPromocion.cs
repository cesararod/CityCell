using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos.Promocion;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.PromocionCC
{
    public class PresentadorConsultaPromocion
    {
        IContratoConsultarPromocion vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaPromocion(IContratoConsultarPromocion vista)
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
            if (msj == RecursoPresentadorPromocion.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorPromocion.alertaModificado;
                vista.alertaRol = RecursoPresentadorPromocion.tipoAlerta;
                vista.alerta = RecursoPresentadorPromocion.alertaHtml + RecursoPresentadorPromocion.MsjModificado
                    + RecursoPresentadorPromocion.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorPromocion.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorPromocion.alertaModificado;
                vista.alertaRol = RecursoPresentadorPromocion.tipoAlerta;
                vista.alerta = RecursoPresentadorPromocion.alertaHtml + RecursoPresentadorPromocion.MsjMAnulado
                    + RecursoPresentadorPromocion.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorPromocion.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorPromocion.alertaModificado;
                vista.alertaRol = RecursoPresentadorPromocion.tipoAlerta;
                vista.alerta = RecursoPresentadorPromocion.alertaHtml + RecursoPresentadorPromocion.MsjCorreo
                    + RecursoPresentadorPromocion.alertaHtmlFinal;
            }
        }

        public void CargarConsultarPromocion()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosPromociones();
                List<Entidad> promocion = comando.Ejecutar();

                foreach (Promocion LaPromocion in promocion)
                {

                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTr;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + LaPromocion.Id_Promo.ToString()
                        + RecursoPresentadorPromocion.CloseTd;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + LaPromocion.Fk_Producto
                        + RecursoPresentadorPromocion.CloseTd;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + LaPromocion.Fecha_Creacion
                        + RecursoPresentadorPromocion.CloseTd;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + LaPromocion.Fecha_Fin
                        + RecursoPresentadorPromocion.CloseTd;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + LaPromocion.Fecha_Creacion
                        + RecursoPresentadorPromocion.CloseTd;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + LaPromocion.Precio
                        + RecursoPresentadorPromocion.CloseTd;

                    //Equals cero para factura "Por Pagar"
                    if (LaPromocion.Activo.Equals(0))
                    {
                        vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + RecursoPresentadorPromocion.porActivar
                            + RecursoPresentadorPromocion.CloseTd;

                    }
                    //Equals uno para factura "Pagada"
                    else if (LaPromocion.Activo.Equals(1))
                    {
                        activada = true;
                        vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD + RecursoPresentadorPromocion.Activada
                            + RecursoPresentadorPromocion.CloseTd;
                    }

                    //Acciones de cada contacto
                    vista.promocionesCreadas += RecursoPresentadorPromocion.OpenTD;

                    if (activada == true)
                    {
                        vista.promocionesCreadas +=
                            RecursoPresentadorPromocion.BotonModif + LaPromocion.Id_Promo.ToString()
                            + RecursoPresentadorPromocion.CloseBotonParametro;
                    }
                    else
                    {
                        vista.promocionesCreadas +=
                            RecursoPresentadorPromocion.BotonModif + LaPromocion.Id_Promo.ToString()
                            + RecursoPresentadorPromocion.CloseBotonParametro;
                    }
                    vista.promocionesCreadas += RecursoPresentadorPromocion.CloseTd;
                    vista.promocionesCreadas += RecursoPresentadorPromocion.CloseTr;
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
