using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCC.InterfazDAO;
using DatosCC.InterfazDAO.BackOffice;
using DatosCC.Categoria;
using DatosCC.Marca;
using DatosCC.Producto;
using DatosCC.Promocion;
using DatosCC.Usuario;
using DatosCC.Garantia;


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

        #region Usuario
        static public IDao crearDaoUsuario()
        {
            return new Usuario.DaoUsuario();
        }
        #endregion

        #region Promocion

        static public IDao crearDaoPromocion()
        {
            return new Promocion.DaoPromocion();
        }

        #endregion

        #region Venta

        static public IDao crearDaoVenta()
        {
            return new Venta.DaoVenta();
        }
        #endregion

        #region Garantia
        static public IDao crearDaoGarantia()
        {
            return new Garantia.DaoGarantia();
        }
        #endregion

        #region Reportes
        static public IReportes crearDaoReportes1()
        {
            return new Reportes.DaoReporte1();
        }

        static public IReportes2 crearDaoReportes2()
        {
            return new Reportes.DaoReporte2();
        }
        #endregion
    }
}
