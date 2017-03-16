using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.Promocion;
using DatosCC.Fabrica;
using DatosCC.InterfazDAO;
using Dominio;
using ExceptionCity;

namespace LogicaCC.Comandos.Promocion
{
    /// <summary>
    /// Comando para consultar todas los promociones
    /// </summary>
    public class ComandoConsultarPromocion : Comando<List<Entidad>>
    {
        /// <summary>
        /// Metodo que ejecuta el comando
        /// </summary>
        /// <returns>Entidad que refleja el exito de la ejecucion del comando</returns>
        /// 
        public override List<Entidad> Ejecutar()
        {
            try
            {
                IDao dao = FabricaDAOSqlServer.crearDaoPromocion();
                List<Entidad> respuesta = dao.ConsultarTodos();
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
