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
    public class DaoReporte4 : General, IReportes
    {
        public List<Entidad> ConsultarTodos(Entidad DatosReporte)
        {
            List<Parametro> parameters = new List<Parametro>();
            Parametro theParam = new Parametro();
            List<Entidad> listProducto = new List<Entidad>();

            try
            {
                theParam = new Parametro(Recurso.ParamStatus, SqlDbType.Int,
                    ((Dominio.Entidades.Reporte)DatosReporte).Estado_Id.ToString(), false);
                parameters.Add(theParam);
                //Guardo la tabla que me regresa el procedimiento de consultar contactos
                DataTable dt = EjecutarStoredProcedureTuplas(Recurso.ConsultaUsuario2, parameters);

                //Guardar los datos 
                foreach (DataRow row in dt.Rows)
                {

                    int _id = int.Parse(row[Recurso.UsuarioId].ToString());
                    string _nombre = row[Recurso.UsuarioNombre].ToString();
                    string _apellido = row[Recurso.UsuarioApellido].ToString();
                    string _cedula = row[Recurso.UsuarioCedula].ToString();
                    DateTime _fechaNacimiento = DateTime.Parse(row[Recurso.UsuarioFechaNac].ToString());
                    DateTime _fechaCreacion = DateTime.Parse(row[Recurso.UsuarioFechaCre].ToString());
                    string _email = row[Recurso.UsuarioEmail].ToString();
                    string _telefono = row[Recurso.UsuarioTelefono].ToString();
                    string _celular = row[Recurso.UsuarioCelular].ToString();
                    int _activo = int.Parse(row[Recurso.UsuarioActivo].ToString());


                    Dominio.Entidades.Usuario _ElUsuario = new Dominio.Entidades.Usuario(_id, _nombre, _apellido, _cedula, _telefono, _celular,
                                                            _fechaNacimiento, _fechaCreacion, _email, _activo);
                    //_ElUsuario.Id = facId;

                    listProducto.Add(_ElUsuario);
                }


            }
            catch (FormatException ex)
            {

                /* throw new ExcepcionesTangerine.M8.WrongFormatException(Recurso.Codigo,
                      Recurso.MensajeFormato, ex);*/
            }
            catch (ArgumentNullException ex)
            {

                /* throw new ExcepcionesTangerine.M8.NullArgumentException(Recurso.Codigo,
                     Recurso.MensajeNull, ex);*/
            }
            catch (ExceptionCcConBD ex)
            {

                /*throw new ExceptionsCity(Recurso.Codigo,
                   Recurso.MensajeSQL, ex);*/
            }
            catch (Exception ex)
            {

                /*throw new ExceptionsCity(Recurso.Codigo,
                    Recurso.MensajeOtro, ex);*/
            }

            return listProducto;
        }
    }
}
