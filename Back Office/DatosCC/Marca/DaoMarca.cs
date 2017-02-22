using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Entidades;


using ExceptionCity;
using DatosCC.InterfazDAO.BackOffice;

namespace DatosCC.Marca
{
    public class DaoMarca : General, IDaoMarca
    {
        /// <summary>
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="LaMarca">Objeto de tipo Marca para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>

        public bool Agregar(Entidad LaMarca)
        {
            
            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoMarca.ParamNombre, SqlDbType.VarChar,
                    ((Dominio.Entidades.Marca)LaMarca).Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamImagen, SqlDbType.VarChar,
                    ((Dominio.Entidades.Marca)LaMarca).Imagen, false);
                parameters.Add(theParam);
                
                theParam = new Parametro(RecursoMarca.ParamStatus, SqlDbType.Int,
                    ((Dominio.Entidades.Marca)LaMarca).Activo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamFechaCreacion, SqlDbType.Date,
                    ((Dominio.Entidades.Marca)LaMarca).Fecha.ToString(), false);
                parameters.Add(theParam);

               List<Resultado> results = EjecutarStoredProcedure(RecursoMarca.AddNuevaMarca, parameters);

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

        /// <summary>
        /// Metodo para modificar un marca en la base de datos.
        /// </summary>
        /// <param name="parametro">objeto de tipo Marca para modificar en bd</param>
        /// <returns>true si fue modificado</returns>
        public bool Modificar(Entidad LaMarca)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Marca _LaMarca = (Dominio.Entidades.Marca)LaMarca;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoMarca.ParamId, SqlDbType.Int, _LaMarca.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamNombre, SqlDbType.VarChar, _LaMarca.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamImagen, SqlDbType.VarChar, _LaMarca.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamStatus, SqlDbType.Int, _LaMarca.Id.ToString(), false);
                parameters.Add(theParam);

                //Se manda a ejecutar el stored procedure M8_ModificarFactura y todos los parametros que recibe
                EjecutarStoredProcedure(RecursoMarca.ChangeMarca, parameters);

            }
            catch (FormatException ex)
            {
                
            }
            catch (ArgumentNullException ex)
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

        /// <summary>
        /// Metodo para modificar un marca en la base de datos.
        /// </summary>
        /// <param name="parametro">objeto de tipo Marca para desactivar en bd</param>
        /// <returns>true si fue desactivado</returns>
       
        public bool Desactivar(Entidad LaMarca)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Marca _LaMarca = (Dominio.Entidades.Marca)LaMarca;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoMarca.ParamId, SqlDbType.Int, _LaMarca.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamStatus, SqlDbType.Int, _LaMarca.Id.ToString(), false);
                parameters.Add(theParam);

                //Se manda a ejecutar el stored procedure M8_ModificarFactura y todos los parametros que recibe
                EjecutarStoredProcedure(RecursoMarca.DeactivateMarca, parameters);

            }
            catch (FormatException ex)
            {

            }
            catch (ArgumentNullException ex)
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
