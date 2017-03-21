using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Venta
    {
        #region Atributos
        private int id_venta;
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
            get { return id_venta; }
            set { id_venta = value; }

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
    }
}
