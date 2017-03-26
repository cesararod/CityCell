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
        private string Nmarca;
        private string Ncategoria;

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

        public string NMarca
        {
            get { return Nmarca; }
            set { Nmarca = value; }

        }

        public string NCategoria
        {
            get { return Ncategoria; }
            set { Ncategoria = value; }

        }
        #endregion

        #region Constructores

        public Garantia() : base()
        {
            this.marca = 0;
            this.cateoria = 0;
            this.descripcion = string.Empty;
        }


        public Garantia(int inputid, string inputmarca, string inputcateoria, string inputdescripcion)
        {
            this.IdGar = inputid;
            this.Nmarca = inputmarca;
            this.Ncategoria = inputcateoria;
            this.descripcion = inputdescripcion;
        }
        #endregion
    }
}
