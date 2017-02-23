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

namespace DatosCC.Categoria
{
    public class DaoCategoria : General, IDao
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
                theParam = new Parametro(RecursoCategoria.ParamNombre, SqlDbType.VarChar,((Dominio.Entidades.Categoria)LaCategoria).Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamDestacado, SqlDbType.Int, LaCategoria.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamStatus, SqlDbType.Int,((Dominio.Entidades.Categoria)LaCategoria).Activo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamFechaCreacion, SqlDbType.Date,((Dominio.Entidades.Categoria)LaCategoria).Fecha_Creacion.ToString(), 
                    false);
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

        /// <summary>
        /// Metodo para modificar un Categoria en la base de datos.
        /// </summary>
        /// <param name="parametro">objeto de tipo Categoria para modificar en bd</param>
        /// <returns>true si fue modificado</returns>
        public bool Modificar(Entidad LaCategoria)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Categoria _LaCategoria = (Dominio.Entidades.Categoria)LaCategoria;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoCategoria.ParamId, SqlDbType.Int, _LaCategoria.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamNombre, SqlDbType.VarChar, _LaCategoria.Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamStatus, SqlDbType.Int, _LaCategoria.Activo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamDestacado, SqlDbType.Int, _LaCategoria.Destacado.ToString(), false);
                parameters.Add(theParam);
                

                EjecutarStoredProcedure(RecursoCategoria.ChangeCategoria, parameters);

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
        /// Metodo para modificar un Categoria en la base de datos.
        /// </summary>
        /// <param name="parametro">objeto de tipo Categoria para desactivar en bd</param>
        /// <returns>true si fue desactivado</returns>
        public bool Desactivar(Entidad LaCategoria)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Categoria _LaCategoria = (Dominio.Entidades.Categoria)LaCategoria;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoCategoria.ParamId, SqlDbType.Int, _LaCategoria.Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoCategoria.ParamStatus, SqlDbType.Int, _LaCategoria.Id.ToString(), false);
                parameters.Add(theParam);

                EjecutarStoredProcedure(RecursoCategoria.DeactivateCate, parameters);

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
            Dominio.Entidades.Categoria _LaCategoria = (Dominio.Entidades.Categoria)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoCategoria.ParamId, SqlDbType.Int,
                    _LaCategoria.Id.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoCategoria.ConsultCategoriaXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];

                int _id = int.Parse(row[RecursoCategoria.ProductoId].ToString());
                String _nombre = row[RecursoCategoria.ProductoNombre].ToString();
                String _destacado = row[RecursoCategoria.ProductoDescripcion].ToString();
                int _activo = int.Parse(row[RecursoCategoria.ProductoActivo].ToString());         
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoCategoria.ProductoFechaCre].ToString());
                int _fkCategoria = int.Parse(row[RecursoCategoria.ProductofKCategoria].ToString());

                _LaCategoria = new Dominio.Entidades.Categoria(_id, _nombre, _destacado, _activo, _fechaCreacion, _fkCategoria);
                //_LaCategoria.Id = _id;

            }
            catch (FormatException ex)
            {

                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoCategoria.Codigo,
                     RecursoCategoria.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoCategoria.Codigo,
                    RecursoCategoria.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoCategoria.Codigo,
                   RecursoCategoria.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoCategoria.Codigo,
                    RecursoCategoria.MensajeOtro, ex);*/
            }

            return _LaCategoria;
        }

        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listCategoria = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoCategoria.ConsultCategorias, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[RecursoCategoria.ProductoId].ToString());
                    String _nombre = row[RecursoCategoria.ProductoNombre].ToString();
                    String _destacado = row[RecursoCategoria.ProductoDescripcion].ToString();
                    int _activo = int.Parse(row[RecursoCategoria.ProductoActivo].ToString());
                    DateTime _fechaCreacion = DateTime.Parse(row[RecursoCategoria.ProductoFechaCre].ToString());
                    int _fkCategoria = int.Parse(row[RecursoCategoria.ProductofKCategoria].ToString());


                    Dominio.Entidades.Categoria _LaCategoria = new Dominio.Entidades.Categoria(_id, _nombre, _destacado, _activo, _fechaCreacion, _fkCategoria);
                    //_ElProducto.Id = facId;

                    //listCategoria.Add(_LaCategoria);
                }


            }
            catch (FormatException ex)
            {

                /* throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoCategoria.Codigo,
                      RecursoCategoria.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /* throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoCategoria.Codigo,
                     RecursoCategoria.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExceptionsCity(RecursoCategoria.Codigo,
                   RecursoCategoria.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {

                /*throw new ExceptionsCity(RecursoCategoria.Codigo,
                    RecursoCategoria.MensajeOtro, ex);*/
            }

            return listCategoria;
        }
    }
}
