﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.Usuario;
using DatosCC.Fabrica;
using DatosCC.InterfazDAO;
using Dominio;
using ExceptionCity;

namespace LogicaCC.Comandos.Producto
{
    public class ComandoActivarProducto : Comando<bool>
    {
        // <summary>
        /// Constructor del comando
        /// </summary>
        /// <param name="parametro">Factura a categoria</param>
        public ComandoActivarProducto(Entidad parametro)
        {
            LaEntidad = parametro;
        }

        /// <summary>
        /// Metodo que ejecuta el comando
        /// </summary>
        /// <returns>booleano que refleja el exito de la ejecucion del comando</returns>
        public override bool Ejecutar()
        {
            try
            {
                IDao dao = FabricaDAOSqlServer.crearDaoProducto();
                bool respuesta = dao.Desactivar(this.LaEntidad);
                return respuesta;
            }
            catch (ArgumentNullException ex)
            {

                throw new NullArgumentException(ResourcesLogic.Codigo, ResourcesLogic.Mensaje, ex);
            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(ResourcesLogic.Codigo, ResourcesLogic.Mensaje_Error_Formato, ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
