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

namespace DatosCC.Usuario
{
    public class DaoUsuario : General, IDao
    {
        /// <summary>
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="ElUsuario">Objeto de tipo Categoria para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Agregar(Entidad ElUsuario)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoUsuario.ParamNombre, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamApellido, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Apellido,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamCedula, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Cedula.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamTelefono, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Telefono,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamCelular, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Celular,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamPassword, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Password,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamFechaNacimieto, SqlDbType.Date, ((Dominio.Entidades.Usuario)ElUsuario).Fecha_Nacimiento.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamFechaIngreso, SqlDbType.Date, ((Dominio.Entidades.Usuario)ElUsuario).Fecha_Ingreso.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamMail, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Email, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamGenero, SqlDbType.Int, ((Dominio.Entidades.Usuario)ElUsuario).Fk_Genero.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamRol, SqlDbType.Int, ((Dominio.Entidades.Usuario)ElUsuario).Fk_Rol.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamTipoDoc, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Tipo_Documento,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamOrigen, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Origen,
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamValidacionDC, SqlDbType.Int, ((Dominio.Entidades.Usuario)ElUsuario).Validacion_dc.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamValidoDC, SqlDbType.VarChar, ((Dominio.Entidades.Usuario)ElUsuario).Valido_dc.ToString(),
                    false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoUsuario.AddNuevoUsuario, parameters);

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
                throw new ExceptionsCity(RecursoUsuario.Codigo,
                   RecursoUsuario.MensajeSQL, ex);
            }
            catch (Exception ex)
            {
                throw new ExceptionsCity(RecursoUsuario.Codigo,
                    RecursoUsuario.MensajeOtro, ex);
            }

            return true;
        }

        /// <summary>
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="ElUsuario">Objeto de tipo Categoria para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Modificar(Entidad ElUsuario)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                theParam = new Parametro(RecursoUsuario.ParamNombre, SqlDbType.Int, ((Dominio.Entidades.Producto)ElUsuario).Activo.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamValidoDC, SqlDbType.Float, ((Dominio.Entidades.Producto)ElUsuario).Precio.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamTelefono, SqlDbType.Float, ((Dominio.Entidades.Producto)ElUsuario).Cantidad.ToString(),
                    false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoUsuario.ChangeUsuario, parameters);

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
        /// Método para desactivar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="ElUsuario">Objeto de tipo Categoria para desactivar en la base de datos.</param>
        /// <returns>True si fue desactivada exitosamente.</returns>
        public bool Desactivar(Entidad ElUsuario)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                theParam = new Parametro(RecursoUsuario.ParamId, SqlDbType.Int, ((Dominio.Entidades.Producto)ElUsuario).Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoUsuario.ParamNombre, SqlDbType.Int, ((Dominio.Entidades.Producto)ElUsuario).Activo.ToString(),
                    false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoUsuario.DeactivateUsuario, parameters);

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
            Dominio.Entidades.Producto _ElUsuario = (Dominio.Entidades.Producto)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoUsuario.ParamId, SqlDbType.Int,
                    _ElUsuario.Id.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoUsuario.ConsultUsuarioXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];

                int _id = int.Parse(row[RecursoUsuario.UsuarioId].ToString());
                String _nombre = row[RecursoUsuario.UsuarioNombre].ToString();
                int _activo = int.Parse(row[RecursoUsuario.UsuarioActivo].ToString());
                String _modelo = row[RecursoUsuario.UsuarioApellido].ToString();
                String _descripcion = row[RecursoUsuario.UsuarioTelefono].ToString();
                float _precio = float.Parse(row[RecursoUsuario.UsuarioEmail].ToString());
                int _cantidad = int.Parse(row[RecursoUsuario.UsuarioCelular].ToString());
                float _peso = float.Parse(row[RecursoUsuario.UsuarioPeso].ToString());
                float _alto = float.Parse(row[RecursoUsuario.UsuarioAlto].ToString());
                float _ancho = float.Parse(row[RecursoUsuario.UsuarioAncho].ToString());
                float _largo = float.Parse(row[RecursoUsuario.UsuarioCedula].ToString());
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoUsuario.UsuarioFechaCre].ToString());
                DateTime _fechaModificacion = DateTime.Parse(row[RecursoUsuario.UsuarioFechaNac].ToString());
                int _fkMarca = int.Parse(row[RecursoUsuario.UsuarioFkMARCA].ToString());
                int _fkCategoria = int.Parse(row[RecursoUsuario.UsuariofKCategoria].ToString());

                //Creo un objeto de tipo Compania con los datos de la fila y lo guardo.
                _ElUsuario = new Dominio.Entidades.Producto(_id, _nombre, _activo, _modelo, _descripcion, _precio, _cantidad, _peso,
                                                              _alto, _ancho, _largo, _fechaCreacion, _fechaModificacion, _fkMarca, _fkCategoria);
                //_ElUsuario.Id = _id;

            }
            catch (FormatException ex)
            {

                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoUsuario.Codigo,
                     RecursoUsuario.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoUsuario.Codigo,
                    RecursoUsuario.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoUsuario.Codigo,
                   RecursoUsuario.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoUsuario.Codigo,
                    RecursoUsuario.MensajeOtro, ex);*/
            }

            return _ElUsuario;
        }

        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listProducto = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoUsuario.ConsultUsuario, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[RecursoUsuario.UsuarioId].ToString());
                    string _nombre = row[RecursoUsuario.UsuarioNombre].ToString();
                    string _apellido = row[RecursoUsuario.UsuarioApellido].ToString();
                    string _cedula = row[RecursoUsuario.UsuarioCedula].ToString();
                    DateTime _fechaNacimiento = DateTime.Parse(row[RecursoUsuario.UsuarioFechaNac].ToString());
                    DateTime _fechaCreacion = DateTime.Parse(row[RecursoUsuario.UsuarioFechaCre].ToString());
                    string _email = row[RecursoUsuario.UsuarioEmail].ToString();
                    string _telefono = row[RecursoUsuario.UsuarioTelefono].ToString();
                    string _celular = row[RecursoUsuario.UsuarioCelular].ToString();

                    Dominio.Entidades.Usuario _ElUsuario = new Dominio.Entidades.Usuario(_id, _nombre, _apellido, _cedula, _telefono, _celular,
                                                            _fechaNacimiento, _fechaCreacion, _email);
                    //_ElUsuario.Id = facId;

                    listProducto.Add(_ElUsuario);
                }


            }
            catch (FormatException ex)
            {

                /* throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoUsuario.Codigo,
                      RecursoUsuario.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /* throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoUsuario.Codigo,
                     RecursoUsuario.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExceptionsCity(RecursoUsuario.Codigo,
                   RecursoUsuario.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {

                /*throw new ExceptionsCity(RecursoUsuario.Codigo,
                    RecursoUsuario.MensajeOtro, ex);*/
            }

            return listProducto;
        }
    }
}
