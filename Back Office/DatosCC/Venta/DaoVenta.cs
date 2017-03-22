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

namespace DatosCC.Venta
{
    public class DaoVenta : General, IDao
    {
        /// <summary>
        /// Método para agregar una Venta nueva en la base de datos.
        /// </summary>
        /// <param name="LaVenta">Objeto de tipo Venta para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Agregar(Entidad LaVenta)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoVenta.ParamNombre, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamApellido, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Apellido,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamCedula, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Cedula.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamTelefono, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Telefono,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamCelular, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Celular,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamPassword, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Password,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamFechaNacimieto, SqlDbType.Date, ((Dominio.Entidades.Usuario)LaVenta).Fecha_Nacimiento.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamFechaIngreso, SqlDbType.Date, ((Dominio.Entidades.Usuario)LaVenta).Fecha_Ingreso.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamStatus, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Email, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamGenero, SqlDbType.Int, ((Dominio.Entidades.Usuario)LaVenta).Fk_Genero.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamRol, SqlDbType.Int, ((Dominio.Entidades.Usuario)LaVenta).Fk_Rol.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamTipoDoc, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Tipo_Documento,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamOrigen, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Origen,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamValidacionDC, SqlDbType.Int, ((Dominio.Entidades.Usuario)LaVenta).Validacion_dc.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamValidoDC, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)LaVenta).Valido_dc.ToString(),
                    false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoVenta.AddNuevoUsuario, parameters);

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
                throw new ExceptionsCity(RecursoVenta.Codigo,
                   RecursoVenta.MensajeSQL, ex);
            }
            catch (Exception ex)
            {
                throw new ExceptionsCity(RecursoVenta.Codigo,
                    RecursoVenta.MensajeOtro, ex);
            }

            return true;
        }

        /// <summary>
        /// Método para agregar una Venta nueva en la base de datos.
        /// </summary>
        /// <param name="LaVenta">Objeto de tipo Venta para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Modificar(Entidad LaVenta)
        {
            Parametro theParam = new Parametro();
            List<Parametro> parameters = new List<Parametro>();
            try
            {
                theParam = new Parametro(RecursoVenta.ParamId, SqlDbType.Int, ((Dominio.Entidades.Venta)LaVenta).Id_Venta.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamStatus, SqlDbType.Int, ((Dominio.Entidades.Venta)LaVenta).Estatus.ToString(), false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoVenta.ChangeVenta, parameters);

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
                throw new ExceptionsCity(RecursoVenta.Codigo,
                   RecursoVenta.MensajeSQL, ex);
            }
            catch (Exception ex)
            {
                throw new ExceptionsCity(RecursoVenta.Codigo,
                    RecursoVenta.MensajeOtro, ex);
            }

            return true;
        }

        /// <summary>
        /// Método para desactivar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="LaVenta">Objeto de tipo Categoria para desactivar en la base de datos.</param>
        /// <returns>True si fue desactivada exitosamente.</returns>
        public bool Desactivar(Entidad LaVenta)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                theParam = new Parametro(RecursoVenta.ParamId, SqlDbType.Int, ((Dominio.Entidades.Producto)LaVenta).Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoVenta.ParamNombre, SqlDbType.Int, ((Dominio.Entidades.Producto)LaVenta).Activo.ToString(),
                    false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoVenta.DeactivateUsuario, parameters);

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

        public Entidad ConsultarXId(Entidad parametro)
        {
            List<Parametro> parameters = new List<Parametro>();
            Dominio.Entidades.Producto _LaVenta = (Dominio.Entidades.Producto)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoVenta.ParamId, SqlDbType.Int,
                    _LaVenta.Id.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoVenta.ConsultUsuarioXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];

                int _id = int.Parse(row[RecursoVenta.VentaId].ToString());
                String _nombre = row[RecursoVenta.VentaNombre].ToString();
                int _activo = int.Parse(row[RecursoVenta.VentaModelo].ToString());
                String _modelo = row[RecursoVenta.VentaApellido].ToString();
                String _descripcion = row[RecursoVenta.VentaPedido].ToString();
                float _precio = float.Parse(row[RecursoVenta.ventaSub].ToString());
                int _cantidad = int.Parse(row[RecursoVenta.VentaIva].ToString());
                float _peso = float.Parse(row[RecursoVenta.VentaNPago].ToString());
                float _alto = float.Parse(row[RecursoVenta.VentaProducto].ToString());
                float _ancho = float.Parse(row[RecursoVenta.VentaOperador].ToString());
                float _largo = float.Parse(row[RecursoVenta.VentaTracking].ToString());
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoVenta.ventaFecha].ToString());
                DateTime _fechaModificacion = DateTime.Parse(row[RecursoVenta.VentaDirFact].ToString());
                int _fkMarca = int.Parse(row[RecursoVenta.VentasPEnvio].ToString());
                int _fkCategoria = int.Parse(row[RecursoVenta.VentaEstatus].ToString());

                //Creo un objeto de tipo Compania con los datos de la fila y lo guardo.
                _LaVenta = new Dominio.Entidades.Producto(_id, _nombre, _activo, _modelo, _descripcion, _precio, _cantidad, _peso,
                                                              _alto, _ancho, _largo, _fechaCreacion, _fechaModificacion, _fkMarca, _fkCategoria);
                //_LaVenta.Id = _id;

            }
            catch (FormatException ex)
            {

                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoVenta.Codigo,
                     RecursoVenta.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoVenta.Codigo,
                    RecursoVenta.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoVenta.Codigo,
                   RecursoVenta.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoVenta.Codigo,
                    RecursoVenta.MensajeOtro, ex);*/
            }

            return _LaVenta;
        }

        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listVenta = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoVenta.ConsultVenta, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    string _producto = row[RecursoVenta.VentaProducto].ToString();
                    string _marca = row[RecursoVenta.VentaMarca].ToString();
                    int _id = int.Parse(row[RecursoVenta.VentaId].ToString());
                    string _nombre = row[RecursoVenta.VentaNombre].ToString();
                    string _apellido = row[RecursoVenta.VentaApellido].ToString();
                    string _tracking = row[RecursoVenta.VentaTracking].ToString();
                    DateTime _fechaCreacion = DateTime.Parse(row[RecursoVenta.ventaFecha].ToString());
                    string _subtotal = row[RecursoVenta.ventaSub].ToString();
                    string _pedido = row[RecursoVenta.VentaPedido].ToString();
                    string _iva = row[RecursoVenta.VentaIva].ToString();
                    string _precioEnvio = row[RecursoVenta.VentasPEnvio].ToString();
                    string _estatus = row[RecursoVenta.VentaEstatus].ToString();
                    string _dirFact = row[RecursoVenta.VentaDirFact].ToString();
                    string _dirEnv = row[RecursoVenta.VentaDirEnv].ToString();
                    string _numPago = row[RecursoVenta.VentaNPago].ToString();
                    string _operador = row[RecursoVenta.VentaOperador].ToString();
                    string _modelo = row[RecursoVenta.VentaModelo].ToString();


                    Dominio.Entidades.Venta _LaVenta = new Dominio.Entidades.Venta(_id, _nombre, _apellido, _tracking, _subtotal, _pedido,
                                              _fechaCreacion, _iva, _precioEnvio, _estatus, _dirFact, _dirEnv, _numPago, _operador, _producto, _modelo, _marca);
                    
                    listVenta.Add(_LaVenta);
                }


            }
            catch (FormatException ex)
            {

                /* throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoVenta.Codigo,
                      RecursoVenta.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /* throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoVenta.Codigo,
                     RecursoVenta.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {
                throw new ExceptionsCity(RecursoVenta.Codigo,
                   RecursoVenta.MensajeSQL, ex);
            }
            catch (Exception ex)
            {
                throw new ExceptionsCity(RecursoVenta.Codigo,
                    RecursoVenta.MensajeOtro, ex);
            }

            return listVenta;
        }
    }
}
