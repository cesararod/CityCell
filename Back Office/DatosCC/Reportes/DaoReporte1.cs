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


namespace DatosCC.Reportes
{
    public class DaoReporte1 : General, IReportes
    {
        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos(Entidad DatosReporte)
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> RespuestaReporte = new List<Entidad>();

            try
            {
                theParam = new Parametro(Recurso.ParamEstado, SqlDbType.Int,
                    ((Dominio.Entidades.Reporte)DatosReporte).Estado_Id.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(Recurso.ParamFechaInicio, SqlDbType.DateTime,
                    ((Dominio.Entidades.Reporte)DatosReporte).Fecha_Inicio.ToString(), false);
                parameters.Add(theParam);

                theParam = new Parametro(Recurso.ParamFechaFin, SqlDbType.DateTime,
                    ((Dominio.Entidades.Reporte)DatosReporte).Fecha_Fin.ToString(), false);
                parameters.Add(theParam);

                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(Recurso.Reporte1, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    string _nombre = row[Recurso.Nombre].ToString();
                    string _apellido = row[Recurso.Apellido].ToString();
                    string _ciudad = row[Recurso.Ciudad].ToString();
                    float _subtotal = float.Parse(row[Recurso.SubTotal].ToString());
                    DateTime _fecha = DateTime.Parse(row[Recurso.Fecha].ToString());


                    Dominio.Entidades.Reporte _Reporte1 = new Dominio.Entidades.Reporte(_nombre, _apellido, _ciudad, _fecha, _subtotal);
                    //_ElProducto.Id = facId;

                    RespuestaReporte.Add(_Reporte1);
                }


            }
            catch (FormatException ex)
            {
                throw new WrongFormatException(Recurso.Codigo,
                      Recurso.MensajeFormato, ex);
            }
            catch (ArgumentNullException ex)
            {

                throw new NullArgumentException(Recurso.Codigo,
                     Recurso.MensajeNull, ex);
            }
            catch (ExceptionCcConBD ex)
            {

                throw new ExceptionsCity(Recurso.Codigo,
                   Recurso.MensajeSQL, ex);
            }
            catch (Exception ex)
            {

                throw new ExceptionsCity(Recurso.Codigo,
                    Recurso.MensajeOtro, ex);
            }

            return RespuestaReporte;
        }
    }
}
