using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionCity;
using Dominio;
using Dominio.Entidades;
using System.Net.Mail;

namespace LogicaCC.Comandos
{
    public class ComandoCorreos : Comando<bool>
    {
        /// <summary>
        /// Constructor del comando
        /// </summary>
        /// <param name="parametro">Factura a agregar</param>
        public ComandoCorreos(Entidad parametro)
        {
            LaEntidad = parametro;
        }

        /// <summary>
        /// Validacion del Correo
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(ResourcesLogic.Codigo,
                     ResourcesLogic.Mensaje_Error_Formato, ex);
            }
        }

        /// <summary>
        /// Metodo que ejecuta el comando
        /// </summary>
        /// <returns>booleano que refleja el exito de la ejecucion del comando</returns>
        public override bool Ejecutar()
        {
            try
            {
                DatosCorreo _datosCorreo = (DatosCorreo)LaEntidad;

                Correo cr = new Correo();
                MailMessage mnsj = new MailMessage();
                mnsj.From = new MailAddress(ResourceLogica.systemmail, ResourceLogica.SysName);
                 

                mnsj.Subject = _datosCorreo.asunto;
                //mnsj.From = new MailAddress(ResourcesLogic.systemmail, ResourcesLogic.SysName);
                mnsj.Body = _datosCorreo.mensjae;
                /* Si deseamos Adjuntar algún archivo*/
                if (_datosCorreo.adjunto != String.Empty)
                    mnsj.Attachments.Add(new Attachment(_datosCorreo.adjunto));

                string[] mailArray = _datosCorreo.destinatario.Split(',');
                List<string> mailsList = new List<string>(mailArray.Length);
                mailsList.AddRange(mailArray);
                mailsList.Reverse();

                foreach (String value in mailsList)
                {
                    IsValid(value);
                    mnsj.To.Add(value);
                }

                cr.mandarCorreo(mnsj);

                return true;
            }
            catch (ArgumentNullException ex)
            {
               throw new NullArgumentException(ResourcesLogic.Codigo,
                    ResourcesLogic.Mensaje, ex);
            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(ResourcesLogic.Codigo,
                     ResourcesLogic.Mensaje_Error_Formato, ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
