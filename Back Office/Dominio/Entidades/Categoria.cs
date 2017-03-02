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
        private string destacado;
        private string activo;
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

        public string Destacado
        {
            get { return destacado; }
            set { destacado = value; }
            
        }

        public string Activo
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

        public Categoria()
        {
            id = 0;
            nombre = String.Empty;
            destacado = String.Empty;
            activo = String.Empty;
            fecha_creacion = DateTime.Now;
            fk_categoria = 0;
        }

        public Categoria(int inputId, string inputNombre, string inputDestacado, string inputActivo, DateTime inputFechaCrea, int inputCategoria)
        {
            id = inputId;
            nombre = inputNombre;
            destacado = inputDestacado;
            activo = inputActivo;
            fecha_creacion = inputFechaCrea;
            fk_categoria = inputCategoria;
        }   

        public Categoria(string inputNombre, string inputDestacado, string inputActivo, DateTime inputFechaCrea, int inputCategoria)
        {
            
            nombre = inputNombre;
            destacado = inputDestacado;
            activo = inputActivo;
            fecha_creacion = inputFechaCrea;
            fk_categoria = inputCategoria;
        }

        public Categoria(int inputId, string inputNombre, string inputDestacado, string inputActivo, DateTime inputFechaCrea)
        {
            id = inputId;
            nombre = inputNombre;
            destacado = inputDestacado;
            activo = inputActivo;
            fecha_creacion = inputFechaCrea;
        }

        public Categoria(string inputNombre, string inputDestacado, string inputActivo, DateTime inputFechaCrea)
        {
           
            nombre = inputNombre;
            destacado = inputDestacado;
            activo = inputActivo;
            fecha_creacion = inputFechaCrea;
        }
      
        #endregion
    }
}
