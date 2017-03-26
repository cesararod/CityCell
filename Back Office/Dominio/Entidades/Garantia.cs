using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Garantia : Entidad
    {
        #region Atributos
        private int id;
        private int marca;
        private int cateoria;
        private string descripcion;

        #endregion

        #region Get's Set's

        public int IdGar
        {
            get { return id; }
            set { id = value; }

        }

        public int Marca
        {
            get { return marca; }
            set { marca = value; }
           
        }

        public int Cateoria
        {
            get { return cateoria; }
            set { cateoria = value; }

        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }

        }
        #endregion

        #region Constructores

        public Garantia() : base()
        {
            this.marca = 0;
            this.cateoria = 0;
            this.descripcion = string.Empty;
        }


        public Garantia(int inputid, int inputmarca, int inputcateoria, string inputdescripcion)
        {
            this.IdGar = inputid;
            this.marca = inputmarca;
            this.cateoria = inputcateoria;
            this.descripcion = inputdescripcion;
        }
        #endregion
    }
}
