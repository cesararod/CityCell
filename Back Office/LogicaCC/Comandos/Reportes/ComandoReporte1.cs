using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.Reportes;
using DatosCC.Fabrica;
using DatosCC.InterfazDAO.BackOffice;
using Dominio;
using ExceptionCity;

namespace LogicaCC.Comandos.Reportes
{
    public class ComandoReporte1 : Comando<List<Entidad>>
    {
        
        // <summary>
        /// Constructor del comando
        /// </summary>
        /// <param name="parametro"></param>
        public ComandoReporte1(Entidad parametro)
        {
            LaEntidad = parametro;
        }

        /// <summary>
        /// Metodo que ejecuta el comando
        /// </summary>
        /// <returns>booleano que refleja el exito de la ejecucion del comando</returns>// <summary>
        /// 
        public override List<Entidad> Ejecutar()
        {
            try
            {
                IReportes dao = FabricaDAOSqlServer.crearDaoReportes1();
                List<Entidad> respuesta = dao.ConsultarTodos(this.LaEntidad);
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
