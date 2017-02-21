using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ExceptionCity;
using DatosCC.InterfazDAO.BackOffice;

namespace DatosCC.Categoria
{
    public class DaoCategoria : General, IDaoMarca
    {
        /// <summary>
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="LaCategoria">Objeto de tipo Categoria para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>

        public bool Agregar(Entidad LaCategoria)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoCategoria.ParamNombre, SqlDbType.VarChar,
                    ((Dominio.Entidades.Categoria)LaCategoria).Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamImagen, SqlDbType.VarChar,
                    ((Dominio.Entidades.Categoria)LaCategoria).Imagen, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamStatus, SqlDbType.Int,
                    ((Dominio.Entidades.Categoria)LaCategoria).Activo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamFechaCreacion, SqlDbType.Date,
                    ((Dominio.Entidades.Categoria)LaCategoria).Fecha.ToString(), false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoCategoria.AddNuevaCategoria, parameters);

            }
            catch (ArgumentNullException ex)
            {

            }
            catch (FormatException ex)
            {

            }
            catch (System.Data.SqlClient.SqlException ex)
            {

            }
            catch (ExceptionCcConBD ex)
            {

            }
            catch (Exception ex)
            {

            }

            return true;
        }
    }
}
