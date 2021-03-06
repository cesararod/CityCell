﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.Promocion;
using DatosCC.Fabrica;
using DatosCC.InterfazDAO.BackOffice;
using Dominio;
using ExceptionCity;

namespace LogicaCC.Comandos.Reportes
{
    /// <summary>
    /// Comando para consultar todas los promociones
    /// </summary>
    public class ComandoReporte2 : Comando<List<Entidad>>
    {
        
        // <summary>
        /// Constructor del comando
        /// </summary>
        /// <param name="parametro"></param>
        public ComandoReporte2(Entidad parametro)
        {
            LaEntidad = parametro;
        }
        /// <summary>
        /// Metodo que ejecuta el comando
        /// </summary>
        /// <returns>Entidad que refleja el exito de la ejecucion del comando</returns>
        /// 
        public override List<Entidad> Ejecutar()
        {
            try
            {
                IReportes2 dao = FabricaDAOSqlServer.crearDaoReportes2();
                List<Entidad> respuesta = dao.ConsultarTodos(this.LaEntidad);
                return respuesta;
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
