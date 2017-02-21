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
        private int fk_producto;
        private int activo;
        private float precio;
        private DateTime fecha_creacion;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;

        #endregion

        #region Get's Set's


        public int Fk_Producto
        {
            get { return fk_producto; }
           
        }

        public int Activo
        {
            get { return activo; }
            
        }

        public float Precio
        {
            get { return precio; }
            
        }

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }

        }

        public DateTime Fecha_Inicio
        {
            get { return fecha_inicio; }

        }

        public DateTime Fecha_Fin
        {
            get { return fecha_fin; }

        }

        
        #endregion

        #region Constructores

        public Promocion()
        {
            Id = 0;
            fk_producto = 0;
            precio = 0;
            activo = 0;
            fecha_creacion = DateTime.Now;
            fecha_inicio = DateTime.Now;
            fecha_fin = DateTime.Now;
        }
      
        #endregion
    }
}
