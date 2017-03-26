using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ExceptionCity;
using DatosCC.InterfazDAO;

namespace DatosCC.Garantia
{
    public class DaoGarantia : General, IDao
    {
        /// <summary>
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="LaGarantia">Objeto de tipo Garantia para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Agregar(Entidad LaGarantia)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoGarantia.ParamCondiciones, SqlDbType.VarChar, ((Dominio.Entidades.Garantia)LaGarantia).Descripcion, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoGarantia.ParamMarca, SqlDbType.Int, ((Dominio.Entidades.Garantia)LaGarantia).Marca.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoGarantia.ParamCategoria, SqlDbType.Int, ((Dominio.Entidades.Garantia)LaGarantia).Cateoria.ToString(), false);
                parameters.Add(theParam);
                
                List<Resultado> results = EjecutarStoredProcedure(RecursoGarantia.AddNuevaGarantia, parameters);

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
                throw new ExceptionsCity(RecursoGarantia.Codigo,
                   RecursoGarantia.MensajeSQL, ex);
            }
            catch (Exception ex)
            {
                throw new ExceptionsCity(RecursoGarantia.Codigo,
                    RecursoGarantia.MensajeOtro, ex);
            }

            return true;
        }

        /// <summary>
        /// Metodo para modificar un Garantia en la base de datos.
        /// </summary>
        /// <param name="parametro">objeto de tipo Garantia para modificar en bd</param>
        /// <returns>true si fue modificado</returns>
        public bool Modificar(Entidad LaGarantia)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Garantia _LaGarantia = (Dominio.Entidades.Garantia)LaGarantia;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoGarantia.ParamId, SqlDbType.Int, _LaGarantia.IdGar.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoGarantia.ParamCondiciones, SqlDbType.VarChar, ((Dominio.Entidades.Garantia)LaGarantia).Descripcion, false);
                parameters.Add(theParam);

                EjecutarStoredProcedure(RecursoGarantia.ChangeGarantia, parameters);

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
        /// Metodo para modificar un Garantia en la base de datos.
        /// </summary>
        /// <param name="parametro">objeto de tipo Garantia para desactivar en bd</param>
        /// <returns>true si fue desactivado</returns>
        public bool Desactivar(Entidad LaGarantia)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Garantia _LaGarantia = (Dominio.Entidades.Garantia)LaGarantia;
            Parametro theParam = new Parametro();

            try
            {
                

                EjecutarStoredProcedure(RecursoGarantia.DeactivateCate, parameters);

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
            Dominio.Entidades.Garantia _LaGarantia = (Dominio.Entidades.Garantia)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoGarantia.ParamId, SqlDbType.Int,
                    _LaGarantia.IdGar.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoGarantia.ConsultGarantiaXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];
                /*
                int _id = int.Parse(row[RecursoGarantia.GarantiaId].ToString());
                String _nombre = row[RecursoGarantia.GarantiaNombre].ToString();
                int _destacado = int.Parse(row[RecursoGarantia.GarantiaDestacado].ToString());
                int _activo = int.Parse(row[RecursoGarantia.GarantiaActivo].ToString());
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoGarantia.GarantiaFechaCre].ToString());
                int _fkGarantia = int.Parse(row[RecursoGarantia.GarantiafKGarantia].ToString());

                _LaGarantia = new Dominio.Entidades.Garantia(_nombre, _destacado, _activo, _fechaCreacion);*/
                //_LaGarantia.Id = _id;

            }
            catch (FormatException ex)
            {

                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoGarantia.Codigo,
                     RecursoGarantia.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoGarantia.Codigo,
                    RecursoGarantia.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoGarantia.Codigo,
                   RecursoGarantia.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoGarantia.Codigo,
                    RecursoGarantia.MensajeOtro, ex);*/
            }

            return _LaGarantia;
        }

        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listGarantia = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoGarantia.ConsultGarantia, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[RecursoGarantia.GarantiaId].ToString());
                    string _descripcion = row[RecursoGarantia.GarantiaCondiciones].ToString();
                    int _marca = int.Parse(row[RecursoGarantia.GarantiaMarca].ToString());
                    int _categoria = int.Parse(row[RecursoGarantia.GarantiaCategoria].ToString());

                    Dominio.Entidades.Garantia _LaGarantia = new Dominio.Entidades.Garantia(_id, _marca, _categoria, _descripcion);
                  
                    listGarantia.Add(_LaGarantia);
                }


            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(RecursoGarantia.Codigo,
                      RecursoGarantia.MensajeFormato, ex);
            }
            catch (ArgumentNullException ex)
            {

                throw new NullArgumentException(RecursoGarantia.Codigo,
                     RecursoGarantia.MensajeNull, ex);
            }
            catch (ExceptionCcConBD ex)
            {

                throw new ExceptionsCity(RecursoGarantia.Codigo,
                   RecursoGarantia.MensajeSQL, ex);
            }
            catch (Exception ex)
            {

                throw new ExceptionsCity(RecursoGarantia.Codigo,
                    RecursoGarantia.MensajeOtro, ex);
            }

            return listGarantia;
        }
    }
}
