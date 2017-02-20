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
    }
}
