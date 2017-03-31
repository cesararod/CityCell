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
    public class DaoReporte2 : General, IReportes2
    {
        /// <summary>
        /// Funcion que permite buscar todas las facturas en la base de datos
        /// </summary>
        /// <returns>Retorna la lista con todas las facturas</returns>
        public List<Entidad> ConsultarTodos()
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> RespuestaReporte = new List<Entidad>();

            try
            {
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(Recurso.Reporte2, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    string _nombre = row[Recurso.Nombre].ToString();
                    string _apellido = row[Recurso.Apellido].ToString();
                    string _Estatus = row[Recurso.Estatus].ToString();
                    float _subtotal = float.Parse(row[Recurso.SubTotal].ToString());
                    DateTime _fecha = DateTime.Parse(row[Recurso.Fecha].ToString());


                    Dominio.Entidades.Reporte _Reporte1 = new Dominio.Entidades.Reporte(_nombre, _apellido, _Estatus, _fecha, _subtotal);
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
