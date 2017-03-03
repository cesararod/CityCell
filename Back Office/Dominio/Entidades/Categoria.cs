using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Categoria : Entidad
    {
        #region Atributos
        private int id;
        private string nombre;
        private int destacado;
        private int activo;
        private DateTime fecha_creacion;
        private int fk_categoria;

        #endregion

        #region Get's Set's

        public int IdCat
        {
            get { return id; }
            set { id = value; }

        }   

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
           
        }

        public int Destacado
        {
            get { return destacado; }
            set { destacado = value; }
            
        }

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
            
        }        

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
            
        }

        public int Fk_categoria
        {
            get { return fk_categoria; }
            set { fk_categoria = value; }
        }  
        
        #endregion

        #region Constructores

        public Categoria() : base()
        {
            this.nombre = String.Empty;
            this.destacado = 0;
            this.activo = 0;
            this.fecha_creacion = DateTime.Now;
            this.fk_categoria = 0;
        }


        public Categoria(string inputNombre, int inputDestacado, int inputActivo, DateTime inputFechaCrea)
        {

            this.nombre = inputNombre;
            this.destacado = inputDestacado;
            this.activo = inputActivo;
            this.fecha_creacion = inputFechaCrea;
        }
      
        #endregion
    }
}
