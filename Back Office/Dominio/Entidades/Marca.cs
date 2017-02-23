using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Marca: Entidad
    {
        #region Atributos
        private int id;
        private string nombre;
        private string imagen;
        private int activo;
        private DateTime fecha;

        #endregion

        #region Get's Set's


        public int Id
        {
            get { return id; }

        }        

        public string Nombre
        {
            get { return nombre; }
           
        }

        public string Imagen
        {
            get { return imagen; }
            
        }

        public int Activo
        {
            get { return activo; }
            
        }        

        public DateTime Fecha
        {
            get { return fecha; }
            
        }

        
        #endregion

        #region Constructores

        public Marca()
        {
            id = 0;
            nombre = String.Empty;
            imagen = String.Empty;
            activo = 0;
            fecha = DateTime.Now;
        }

        public Marca(int inputId, string inputNombre, string inputImagen, int inputActivo, DateTime inputFecha)
        {
            id = 0;
            nombre = String.Empty;
            imagen = String.Empty;
            activo = inputActivo;
            fecha = DateTime.Now;
        }
        #endregion
    }
}
