using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario : Entidad
    {
        #region Atributos
        private int idUser;
        private string nombre;
        private string apellido;
        private int cedula;
        private string telefono;
        private string celular;
        private string password;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso;
        private string email;
        private string tipo_documento;
        private string origen;
        private int validacion_dc;
        private int valido_dc;
        private int fk_genero;
        private int fk_rol;       

        #endregion

        #region Get's Set's

        public int IdUser
        {
            get { return idUser; }
        } 

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
           
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
            
        }
        
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }

        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }

        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }

        }

        public string Password
        {
            get { return password; }
            set { password = value; }

        }

        public DateTime Fecha_Nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }

        }

        public DateTime Fecha_Ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }

        }

        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public string Tipo_Documento
        {
            get { return tipo_documento; }
            set { tipo_documento = value; }

        }

        public string Origen
        {
            get { return origen; }
            set { origen = value; }

        }

        public int Validacion_dc
        {
            get { return validacion_dc; }
            set { validacion_dc = value; }

        }

        public int Valido_dc
        {
            get { return valido_dc; }
            set { valido_dc = value; }

        }

        public int Fk_Genero
        {
            get { return fk_genero; }
            set { fk_genero = value; }
            
        }

        public int Fk_Rol
        {
            get { return fk_rol; }
            set { fk_rol = value; }

        }       
        #endregion

        #region Constructores

        public Usuario(int inputId, string input_Nombre, string input_Apellido, int input_cedula, string input_telefono, string input_celular,
            string input_password, DateTime input_FNacimineto, DateTime input_FIngreso, string input_email, string input_tDoc, string input_origen
            , int input_validacion_dc, int input_valido_dc, int input_fk_rol, int input_fk_genero)
            : base()
        {
            Id = 0;
            nombre = input_Nombre;
            apellido = input_Apellido;
            cedula = input_cedula;
            telefono = input_telefono;
            celular = input_celular;
            password = input_password;
            fecha_nacimiento = input_FNacimineto;
            fecha_ingreso = input_FIngreso;
            email = input_email;
            tipo_documento = input_tDoc;
            origen = input_origen;
            validacion_dc = input_validacion_dc;
            valido_dc = input_valido_dc;
            fk_rol = input_fk_rol;
            fk_genero = input_fk_genero;
        }
      
        #endregion
    }
}
