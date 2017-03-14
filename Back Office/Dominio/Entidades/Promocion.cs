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
        private int id_promo;
        private int fk_producto;
        private int activo;
        private float precio;
        private DateTime fecha_creacion;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;

        #endregion

        #region Get's Set's

        public int Id_Promo
        {
            get { return id_promo; }
            set { id_promo = value; }

        }

        public int Fk_Producto
        {
            get { return fk_producto; }
            set { fk_producto = value; }
           
        }

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
            
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
            
        }

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }

        }

        public DateTime Fecha_Inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }

        }

        public DateTime Fecha_Fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }

        }

        
        #endregion

        #region Constructores

        public Promocion()
        {
            id_promo = 0;
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
