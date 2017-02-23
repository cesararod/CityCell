﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.InterfazDAO;
using DatosCC.Categoria;
using DatosCC.Marca;
using DatosCC.Producto;
using DatosCC.Promocion;


namespace DatosCC.Fabrica
{
    public class FabricaDAOSqlServer
    {
        #region Categoria

        static public IDao crearDaoCategoria()
        {
            return new Categoria.DaoCategoria();
        }

        #endregion

        #region Marca

        static public IDao crearDaoMarca()
        {
            return new Marca.DaoMarca();
        }

        #endregion

        #region Producto

        static public IDao crearDaoProducto()
        {
            return new Producto.DaoProducto();
        }

        #endregion

        #region Promocion

        /*static public IDao crearDaoPromocion()
        {
            return new Promocion.DaoPromocion();
        }*/

        #endregion
    }
}
