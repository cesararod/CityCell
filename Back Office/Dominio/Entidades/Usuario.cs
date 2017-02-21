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


        public string Nombre
        {
            get { return nombre; }
           
        }

        public string Apellido
        {
            get { return apellido; }
            
        }
        
        public int Cedula
        {
            get { return cedula; }

        }

        public string Telefono
        {
            get { return telefono; }

        }

        public string Celular
        {
            get { return celular; }

        }

        public string Password
        {
            get { return password; }

        }

        public DateTime Fecha_Nacimiento
        {
            get { return fecha_nacimiento; }

        }

        public DateTime Fecha_Ingreso
        {
            get { return fecha_ingreso; }

        }

        public string Email
        {
            get { return email; }

        }

        public string Tipo_Documento
        {
            get { return tipo_documento; }

        }

        public string Origen
        {
            get { return origen; }

        }

        public int Validacion_dc
        {
            get { return validacion_dc; }

        }

        public int Valido_dc
        {
            get { return valido_dc; }

        }

        public int Fk_Genero
        {
            get { return fk_genero; }
            
        }

        public int Fk_Rol
        {
            get { return fk_rol; }

        }       
        #endregion

        #region Constructores

        public Usuario()
        {
            Id = 0;
            nombre = String.Empty;
            apellido = String.Empty;
            cedula = 0;
            telefono = String.Empty;
            celular = String.Empty;
            password = String.Empty;
            fecha_nacimiento = DateTime.Now;
            fecha_ingreso = DateTime.Now;
            email = String.Empty;
            tipo_documento = String.Empty;
            origen = String.Empty;
            validacion_dc = 0;
            valido_dc = 0;
            fk_rol = 0;
            fk_genero = 0;
        }
      
        #endregion
    }
}
