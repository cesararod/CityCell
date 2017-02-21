using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Promocion : Entidad
    {
         #region Atributos
        private string nombre;
        private string imagen;
        private int activo;
        private DateTime fecha;

        #endregion

        #region Get's Set's


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

        public Promocion()
        {
            Id = 0;
            nombre = String.Empty;
            imagen = String.Empty;
            activo = 0;
            fecha = DateTime.Now;
        }
      
        #endregion
    }
}
