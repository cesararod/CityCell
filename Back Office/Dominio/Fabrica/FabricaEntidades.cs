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
    }
}
