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
        private int activo;
        private DateTime fecha_creacion;
        private int fk_categoria;

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

        public string Destacado
        {
            get { return destacado; }
            
        }

        public int Activo
        {
            get { return activo; }
            
        }        

        public DateTime Fecha_Creacion
        {
            get { return fecha_creacion; }
            
        }

        public int Fk_categoria
        {
            get { return fk_categoria; }

        }  
        
        #endregion

        #region Constructores

        public Categoria()
        {
            id = 0;
            nombre = String.Empty;
            destacado = String.Empty;
            activo = 0;
            fecha_creacion = DateTime.Now;
            fk_categoria = 0;
        }

        public Categoria(int inputId, string inputNombre, string inputDestacado, int inputActivo, DateTime inputFechaCrea, int inputCategoria)
        {
            id = inputId;
            nombre = inputNombre;
            destacado = inputDestacado;
            activo = inputActivo;
            fecha_creacion = inputFechaCrea;
            fk_categoria = inputCategoria;
        }
      
        #endregion
    }
}
