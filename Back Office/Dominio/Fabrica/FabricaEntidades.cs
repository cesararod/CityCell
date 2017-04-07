using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Entidades;

namespace Dominio.Fabrica
{
    public class FabricaEntidades
    {
        /// <summary>
        /// Metodo que crea la instancia de la entidad Producto
        /// </summary>
        /// <returns>Retorna la instancia a la clase Marca</returns>
        public static Entidad ProductoVacio()
        {
            return new Producto();
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad Marca
        /// </summary>
        /// <returns>Retorna la instancia a la clase Marca</returns>
         public static Entidad MarcaVacia()
        {
            return new Marca();
        }

         /// <summary>
         /// Metodo que crea la instancia de la entidad Garantia
         /// </summary>
         /// <returns>Retorna la instancia a la clase Garantia</returns>
         public static Entidad GarantiaVacia()
         {
             return new Garantia();
         }
        
        /// <summary>
        /// Metodo que crea la instancia de la entidad Categoria
        /// </summary>
        /// <returns>Retorna la instancia a la clase Categoria</returns>
        public static Entidad CategoriaVacia()
        {
            return new Categoria();
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad Categoria
        /// </summary>
        /// <returns>Retorna la instancia a la clase Categoria</returns>
        public static  Entidad CategoriaVacia(string nombre, int activo, int destacado, DateTime fechaCreacion)
        {
            return new Categoria(nombre, destacado, activo, fechaCreacion);
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad Producto
        /// </summary>
        /// <returns>Retorna la instancia a la clase Marca</returns>
        public static Entidad UsuarioVacio()
        {
            return new Usuario();
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad promocion
        /// </summary>
        /// <returns>Retorna la instancia a la clase Promocion</returns>
        public static Entidad PromocionVacia()
        {
            return new Promocion();
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad Venta
        /// </summary>
        /// <returns>Retorna la instancia a la clase Venta</returns>
        public static Entidad VentaVacia()
        {
            return new Venta();
        }


        /// <summary>
        /// Constructor de CorreoGmailM8.
        /// </summary>
        public static Entidad ObtenerCorreo()
        {
            return new Correo();
        }

        /// <summary>
        /// Constructor de datos correo vacio.
        /// </summary>
        public static Entidad ObtenerDatosCorreo()
        {
            return new DatosCorreo();
        }

        /// <summary>
        /// Constructor de datos correo sin archivo adjunto.
        /// </summary>
        /// <param name="asunto">Asunto del mensaje</param>
        /// <param name="destinatario">Destinatarios del mensaje</param>
        /// <param name="mensaje">Contenido del mensaje</param>
        public static Entidad ObtenerDatosCorreo(string asunto, string destinatario, string mensaje)
        {
            return new DatosCorreo(asunto, destinatario, mensaje);
        }

        /// <summary>
        /// Constructor de datos correo con todos sus atributos.
        /// </summary>
        /// <param name="asunto">Asunto del mensaje</param>
        /// <param name="destinatario">Destinatarios del mensaje</param>
        /// <param name="mensaje">Contenido del mensaje</param>
        /// <param name="adjunto">Archivo adjunto del mensaje</param>
        public static Entidad ObtenerDatosCorreo(string asunto, string destinatario, string mensaje, string adjunto)
        {
            return new DatosCorreo(asunto, destinatario, mensaje, adjunto);
        }

        /// <summary>
        /// Constructor de datos correo con todos sus atributos.
        /// </summary>
        /// <param name="asunto">Asunto del mensaje</param>
        /// <param name="destinatario">Destinatarios del mensaje</param>
        /// <param name="mensaje">Contenido del mensaje</param>
        /// <param name="adjunto">Archivo adjunto del mensaje</param>
        public static Entidad ObtenerDatosCorreo(string asunto, string destinatario, string mensaje, int adjunto)
        {
            return new DatosCorreo(asunto, destinatario, mensaje, adjunto);
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad Reporte
        /// </summary>
        /// <returns>Retorna la instancia a la clase Reporte</returns>
        public static Entidad ReporteVacio()
        {
            return new Reporte();
        }
    }
}
