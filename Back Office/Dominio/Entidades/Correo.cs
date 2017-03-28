using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Dominio.Entidades
{
    public class Correo : Entidad
    {
        /*
        * Cliente SMTP
        * Gmail:  smtp.gmail.com  puerto:587
        * Hotmail: smtp.live.com  puerto:25
        */
        SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

        public Correo()
        {
            /*
             * Autenticacion en el Servidor
             * Utilizaremos nuestra cuenta de correo
             *
             * Direccion de Correo (Gmail o Hotmail)
             * y Contrasena correspondiente
             */
            server.Credentials = new System.Net.NetworkCredential("carr235@gmail.com", "Dragon2libra@");
            server.EnableSsl = true;
        }

        public void mandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        } 
    }
}
