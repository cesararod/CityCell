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
    }
}
