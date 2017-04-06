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

namespace DatosCC.Promocion
{
    public class DaoPromocion : General, IDao
    {
        public bool Agregar(Entidad LaPromocion)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoPromocion.ParamProducto, SqlDbType.Int,
                    ((Dominio.Entidades.Promocion)LaPromocion).Fk_Producto.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamPrecio, SqlDbType.Float,   
                    ((Dominio.Entidades.Promocion)LaPromocion).Precio.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamStatus, SqlDbType.Int,
                    ((Dominio.Entidades.Promocion)LaPromocion).Activo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamFechaInicio, SqlDbType.Date,
                    ((Dominio.Entidades.Promocion)LaPromocion).Fecha_Inicio.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamFechaFin, SqlDbType.Date,
                    ((Dominio.Entidades.Promocion)LaPromocion).Fecha_Fin.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamFechaCreacion, SqlDbType.Date,
                    ((Dominio.Entidades.Promocion)LaPromocion).Fecha_Creacion.ToString(), false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoPromocion.AddNuevaPromocion, parameters);

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
        public bool Modificar(Entidad LaPromocion)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Promocion _LaPromocion = (Dominio.Entidades.Promocion)LaPromocion;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoPromocion.ParamId, SqlDbType.Int, _LaPromocion.Id_Promo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamPrecio, SqlDbType.Float, 
                    ((Dominio.Entidades.Promocion)LaPromocion).Precio.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamFechaInicio, SqlDbType.Date,
                    ((Dominio.Entidades.Promocion)LaPromocion).Fecha_Inicio.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamFechaFin, SqlDbType.Date,
                    ((Dominio.Entidades.Promocion)LaPromocion).Fecha_Fin.ToString(), false);
                parameters.Add(theParam);

                //Se manda a ejecutar el stored procedure M8_ModificarFactura y todos los parametros que recibe
                EjecutarStoredProcedure(RecursoPromocion.Changepromo, parameters);

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

        public bool Desactivar(Entidad LaPromocion)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Usuario _LaPromocion = (Dominio.Entidades.Usuario)LaPromocion;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoPromocion.ParamId, SqlDbType.Int, _LaPromocion.IdUser.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoPromocion.ParamStatus, SqlDbType.Int, _LaPromocion.Activo.ToString(), false);
                parameters.Add(theParam);

                //Se manda a ejecutar el stored procedure M8_ModificarFactura y todos los parametros que recibe
                EjecutarStoredProcedure(RecursoPromocion.Deactivate, parameters);

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
            Dominio.Entidades.Promocion _LaPromocion = (Dominio.Entidades.Promocion)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoPromocion.ParamId, SqlDbType.Int,
                    _LaPromocion.Id.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoPromocion.ConsultMarcaXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];

                int _id = int.Parse(row[RecursoPromocion.PromoId].ToString());
                String _nombre = row[RecursoPromocion.FechaFin].ToString();
                String _imagen = row[RecursoPromocion.ProductoID].ToString();
                int _activo = int.Parse(row[RecursoPromocion.PromoActivo].ToString());
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoPromocion.PromoFechaCre].ToString());

                //_LaPromocion = new Dominio.Entidades.Promocion(_id, _nombre, _imagen, _activo, _fechaCreacion);
                //_LaPromocion.Id = _id;

            }
            catch (FormatException ex)
            {

                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoPromocion.Codigo,
                     RecursoPromocion.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoPromocion.Codigo,
                    RecursoPromocion.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoPromocion.Codigo,
                   RecursoPromocion.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoPromocion.Codigo,
                    RecursoPromocion.MensajeOtro, ex);*/
            }

            return _LaPromocion;
        }

        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listPromociones = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoPromocion.ConsultPromos, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[RecursoPromocion.PromoId].ToString());
                    int _idProducto = int.Parse(row[RecursoPromocion.ProductoID].ToString());
                    int _activo = int.Parse(row[RecursoPromocion.PromoActivo].ToString());
                    float _precio = float.Parse(row[RecursoPromocion.PromoPrecio].ToString());
                    DateTime _fechaCreacion = DateTime.Parse(row[RecursoPromocion.PromoFechaCre].ToString());
                    DateTime _fechaInicio = DateTime.Parse(row[RecursoPromocion.FechaIni].ToString());
                    DateTime _fechaFin = DateTime.Parse(row[RecursoPromocion.FechaFin].ToString());


                    Dominio.Entidades.Promocion _LaPromocion = new Dominio.Entidades.Promocion(_id, _idProducto, _precio, _activo, _fechaInicio, _fechaFin, _fechaCreacion);
                    //_ElProducto.Id = facId;

                    listPromociones.Add(_LaPromocion);
                }


            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(RecursoPromocion.Codigo,
                      RecursoPromocion.MensajeFormato, ex);
            }
            catch (ArgumentNullException ex)
            {

                throw new NullArgumentException(RecursoPromocion.Codigo,
                     RecursoPromocion.MensajeNull, ex);
            }
            catch (ExceptionCcConBD ex)
            {

                throw new ExceptionsCity(RecursoPromocion.Codigo,
                   RecursoPromocion.MensajeSQL, ex);
            }
            catch (Exception ex)
            {

                throw new ExceptionsCity(RecursoPromocion.Codigo,
                    RecursoPromocion.MensajeOtro, ex);
            }

            return listPromociones;
        }
    }
}
