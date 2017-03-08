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
using DatosCC.InterfazDAO;

namespace DatosCC.Marca
{
    public class DaoMarca : General, IDao
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
                theParam = new Parametro(RecursoMarca.ParamId, SqlDbType.Int, _LaMarca.IdMarca.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamNombre, SqlDbType.VarChar, _LaMarca.IdMarca.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamImagen, SqlDbType.VarChar, _LaMarca.IdMarca.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamStatus, SqlDbType.Int, _LaMarca.IdMarca.ToString(), false);
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
                theParam = new Parametro(RecursoMarca.ParamId, SqlDbType.Int, _LaMarca.IdMarca.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoMarca.ParamStatus, SqlDbType.Int, _LaMarca.IdMarca.ToString(), false);
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

        public Entidad ConsultarXId(Entidad parametro)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Marca _LaMarca = (Dominio.Entidades.Marca)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoMarca.ParamId, SqlDbType.Int,
                    _LaMarca.IdMarca.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoMarca.ConsultMarcaXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];

                int _id = int.Parse(row[RecursoMarca.MarcaId].ToString());
                String _nombre = row[RecursoMarca.MarcaNombre].ToString();
                String _imagen = row[RecursoMarca.MarcaImagen].ToString();
                int _activo = int.Parse(row[RecursoMarca.MarcaActivo].ToString());
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoMarca.MarcaFechaCre].ToString());

                _LaMarca = new Dominio.Entidades.Marca(_id, _nombre, _imagen, _activo, _fechaCreacion);
                //_LaMarca.Id = _id;

            }
            catch (FormatException ex)
            {

                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoMarca.Codigo,
                     RecursoMarca.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoMarca.Codigo,
                    RecursoMarca.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoMarca.Codigo,
                   RecursoMarca.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoMarca.Codigo,
                    RecursoMarca.MensajeOtro, ex);*/
            }

            return _LaMarca;
        }

        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listMarca = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoMarca.ConsultMarcas, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[RecursoMarca.MarcaId].ToString());
                    String _nombre = row[RecursoMarca.MarcaNombre].ToString();
                    String _imagen = row[RecursoMarca.MarcaImagen].ToString();
                    int _activo = int.Parse(row[RecursoMarca.MarcaActivo].ToString());
                    DateTime _fechaCreacion = DateTime.Parse(row[RecursoMarca.MarcaFechaCre].ToString());


                    Dominio.Entidades.Marca _LaMarca = new Dominio.Entidades.Marca(_id, _nombre, _imagen, _activo, _fechaCreacion);
                    //_ElProducto.Id = facId;

                    listMarca.Add(_LaMarca);
                }


            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(RecursoMarca.Codigo,
                      RecursoMarca.MensajeFormato, ex);
            }
            catch (ArgumentNullException ex)
            {

                throw new NullArgumentException(RecursoMarca.Codigo,
                     RecursoMarca.MensajeNull, ex);
            }
            catch (ExceptionCcConBD ex)
            {

                throw new ExceptionsCity(RecursoMarca.Codigo,
                   RecursoMarca.MensajeSQL, ex);
            }
            catch (Exception ex)
            {

                throw new ExceptionsCity(RecursoMarca.Codigo,
                    RecursoMarca.MensajeOtro, ex);
            }

            return listMarca;
        }

    }
}
