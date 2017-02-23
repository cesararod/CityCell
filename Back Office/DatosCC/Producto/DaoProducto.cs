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

namespace DatosCC.Producto
{
    public class DaoProducto : General, IDao
    {
        /// <summary>
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="ElProducto">Objeto de tipo Categoria para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Agregar(Entidad ElProducto)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                //Las dos lineas siguientes tienen que repetirlas tantas veces como parametros reciba su stored procedure a llamar
                //Parametro recibe (nombre del primer parametro en su stored procedure, el tipo de dato, el valor, false)
                theParam = new Parametro(RecursoProducto.ParamNombre, SqlDbType.VarChar, ((Dominio.Entidades.Producto)ElProducto).Nombre, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.Paramstatus, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Activo.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamModelo, SqlDbType.VarChar, ((Dominio.Entidades.Producto)ElProducto).Modelo, false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamDescripcion, SqlDbType.VarChar, ((Dominio.Entidades.Producto)ElProducto).Descripcion, 
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamPrecio, SqlDbType.Float, ((Dominio.Entidades.Producto)ElProducto).Precio.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamCantidad, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Cantidad.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamAlto, SqlDbType.Float, ((Dominio.Entidades.Producto)ElProducto).Alto.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamAncho, SqlDbType.Float, ((Dominio.Entidades.Producto)ElProducto).Ancho.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.Paramlargo, SqlDbType.Float, ((Dominio.Entidades.Producto)ElProducto).Largo.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamIdMarca, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Fk_Marca.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamIdCategoria, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Fk_Categoria.ToString(),
                    false);
                parameters.Add(theParam);

                List<Resultado> results = EjecutarStoredProcedure(RecursoProducto.AddNuevoProducto, parameters);

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
        /// Método para agregar una marca nueva en la base de datos.
        /// </summary>
        /// <param name="ElProducto">Objeto de tipo Categoria para agregar en la base de datos.</param>
        /// <returns>True si fue agregada exitosamente.</returns>
        public bool Modificar(Entidad ElProducto)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                theParam = new Parametro(RecursoProducto.Paramstatus, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Activo.ToString(),
                    false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.ParamPrecio, SqlDbType.Float, ((Dominio.Entidades.Producto)ElProducto).Precio.ToString(),
                    false);
                parameters.Add(theParam);                

                List<Resultado> results = EjecutarStoredProcedure(RecursoProducto.AddNuevoProducto, parameters);

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
        /// <param name="ElProducto">Objeto de tipo Categoria para desactivar en la base de datos.</param>
        /// <returns>True si fue desactivada exitosamente.</returns>
        public bool Desactivar(Entidad ElProducto)
        {

            Parametro theParam = new Parametro();
            try
            {
                List<Parametro> parameters = new List<Parametro>();

                theParam = new Parametro(RecursoProducto.ParamId, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(RecursoProducto.Paramstatus, SqlDbType.Int, ((Dominio.Entidades.Producto)ElProducto).Activo.ToString(),
                    false);
                parameters.Add(theParam);
                
                List<Resultado> results = EjecutarStoredProcedure(RecursoProducto.AddNuevoProducto, parameters);

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
            Dominio.Entidades.Producto _ElProducto = (Dominio.Entidades.Producto)parametro;
            Parametro theParam = new Parametro();

            try
            {
                theParam = new Parametro(RecursoProducto.ParamId, SqlDbType.Int,
                    _ElProducto.Id.ToString(), false);
                parameters.Add(theParam);

                DataTable dt = EjecutarStoredProcedureTuplas(RecursoProducto.ConsultProductoXId, parameters);

                //Guardar los datos 
                DataRow row = dt.Rows[0];

                int _id = int.Parse(row[RecursoProducto.ProductoId].ToString());
                String _nombre = row[RecursoProducto.ProductoNombre].ToString();
                int _activo = int.Parse(row[RecursoProducto.ProductoActivo].ToString());
                String _modelo = row[RecursoProducto.ProductoModelo].ToString();
                String _descripcion = row[RecursoProducto.ProductoDescripcion].ToString();
                float _precio = float.Parse(row[RecursoProducto.ProductoPrecio].ToString());
                int _cantidad = int.Parse(row[RecursoProducto.ProductoCantidad].ToString());
                float _peso = float.Parse(row[RecursoProducto.ProductoPeso].ToString());
                float _alto = float.Parse(row[RecursoProducto.ProductoAlto].ToString());
                float _ancho = float.Parse(row[RecursoProducto.ProductoAncho].ToString());
                float _largo = float.Parse(row[RecursoProducto.ProductoLargo].ToString());
                DateTime _fechaCreacion = DateTime.Parse(row[RecursoProducto.ProductoFechaCre].ToString());
                DateTime _fechaModificacion = DateTime.Parse(row[RecursoProducto.ProductoFechaMod].ToString());
                int _fkMarca = int.Parse(row[RecursoProducto.ProductoFkMARCA].ToString());
                int _fkCategoria = int.Parse(row[RecursoProducto.ProductofKCategoria].ToString());

                //Creo un objeto de tipo Compania con los datos de la fila y lo guardo.
                _ElProducto = new Dominio.Entidades.Producto(_id, _nombre, _activo, _modelo, _descripcion, _precio, _cantidad, _peso, 
                                                              _alto, _ancho, _largo, _fechaCreacion, _fechaModificacion, _fkMarca, _fkCategoria);
                //_ElProducto.Id = _id;

            }
            catch (FormatException ex)
            {
                
                /*throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoProducto.Codigo,
                     RecursoProducto.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {
                
                /*throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoProducto.Codigo,
                    RecursoProducto.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {
                
                /*throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoProducto.Codigo,
                   RecursoProducto.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {
                /*
                throw new ExcepcionesTangerine.ExceptionsTangerine(RecursoProducto.Codigo,
                    RecursoProducto.MensajeOtro, ex);*/
            }

            return _ElProducto;
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
                DataTable dt = EjecutarStoredProcedureTuplas(RecursoProducto.ConsultProductos, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[RecursoProducto.ProductoId].ToString());
                    String _nombre = row[RecursoProducto.ProductoNombre].ToString();
                    int _activo = int.Parse(row[RecursoProducto.ProductoActivo].ToString());
                    String _modelo = row[RecursoProducto.ProductoModelo].ToString();
                    String _descripcion = row[RecursoProducto.ProductoDescripcion].ToString();
                    float _precio = float.Parse(row[RecursoProducto.ProductoPrecio].ToString());
                    int _cantidad = int.Parse(row[RecursoProducto.ProductoCantidad].ToString());
                    float _peso = float.Parse(row[RecursoProducto.ProductoPeso].ToString());
                    float _alto = float.Parse(row[RecursoProducto.ProductoAlto].ToString());
                    float _ancho = float.Parse(row[RecursoProducto.ProductoAncho].ToString());
                    float _largo = float.Parse(row[RecursoProducto.ProductoLargo].ToString());
                    DateTime _fechaCreacion = DateTime.Parse(row[RecursoProducto.ProductoFechaCre].ToString());
                    DateTime _fechaModificacion = DateTime.Parse(row[RecursoProducto.ProductoFechaMod].ToString());
                    int _fkMarca = int.Parse(row[RecursoProducto.ProductoFkMARCA].ToString());
                    int _fkCategoria = int.Parse(row[RecursoProducto.ProductofKCategoria].ToString());


                    Dominio.Entidades.Producto _ElProducto = new Dominio.Entidades.Producto(_id, _nombre, _activo, _modelo, _descripcion, _precio, _cantidad, _peso,
                                                              _alto, _ancho, _largo, _fechaCreacion, _fechaModificacion, _fkMarca, _fkCategoria);
                    //_ElProducto.Id = facId;

                    listProducto.Add(_ElProducto);
                }


            }
            catch (FormatException ex)
            {
                
               /* throw new ExcepcionesTangerine.M8.WrongFormatException(RecursoProducto.Codigo,
                     RecursoProducto.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {
                
               /* throw new ExcepcionesTangerine.M8.NullArgumentException(RecursoProducto.Codigo,
                    RecursoProducto.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {
               
                /*throw new ExceptionsCity(RecursoProducto.Codigo,
                   RecursoProducto.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {

                /*throw new ExceptionsCity(RecursoProducto.Codigo,
                    RecursoProducto.MensajeOtro, ex);*/
            }

            return listProducto;
        }

    }
}
