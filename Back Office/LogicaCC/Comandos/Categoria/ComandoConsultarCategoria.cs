using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.Categoria;
using DatosCC.Fabrica;
using DatosCC.InterfazDAO;
using Dominio;
using ExceptionCity;

namespace LogicaCC.Comandos
{
    /// <summary>
    /// Comando para consultar todas las categorias
    /// </summary>
    public class ComandoConsultarCategoria : Comando<List<Entidad>>
    {
        /// <summary>
        /// Metodo que ejecuta el comando
        /// </summary>
        /// <returns>Entidad que refleja el exito de la ejecucion del comando</returns>
        public override List<Entidad> Ejecutar()
        {
            try
            {
                IDao daoCategoria = FabricaDAOSqlServer.crearDaoCategoria();
                List<Entidad> respuesta = daoCategoria.ConsultarTodos();
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
