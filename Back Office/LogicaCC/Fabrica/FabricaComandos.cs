using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using LogicaCC.Comandos;

namespace LogicaCC.Fabrica
{
    public class FabricaComandos
    {
        #region Categoria

        /// <summary>
        /// metodo para crear comando que permite agregar una categoria
        /// </summary>
        /// <param name="categoria">entidad sobre la cual se va a trabajar el comando</param>
        /// <returns></returns>
        public static Comando<bool> CrearAgregarCategoria(Entidad categoria)
        {
            Comando<bool> respuesta = new ComandoAgregarCategoria(categoria);
            return respuesta;
        }

        #endregion

        #region Marca

       

        #endregion

        #region Producto

        

        #endregion

        #region Promocion

        

        #endregion
    }
}
