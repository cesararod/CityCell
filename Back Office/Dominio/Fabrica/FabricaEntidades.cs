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
        /// Metodo que crea la instancia de la entidad Marca
        /// </summary>
        /// <returns>Retorna la instancia a la clase Marca</returns>
        static public Entidad MarcaVacia()
        {
            return new Dominio.Entidades.Marca();
        }
        
        /// <summary>
        /// Metodo que crea la instancia de la entidad Categoria
        /// </summary>
        /// <returns>Retorna la instancia a la clase Categoria</returns>
        static public Entidad CategoriaVacia()
        {
            return new Dominio.Entidades.Categoria();
        }

        /// <summary>
        /// Metodo que crea la instancia de la entidad Categoria
        /// </summary>
        /// <returns>Retorna la instancia a la clase Categoria</returns>
        static public Entidad CategoriaNoIdMadre(string nombre, string activo, string destacado,  DateTime fechaCreacion)
        {
            return new Dominio.Entidades.Categoria(nombre, activo, destacado, fechaCreacion);
        }
    }
}
